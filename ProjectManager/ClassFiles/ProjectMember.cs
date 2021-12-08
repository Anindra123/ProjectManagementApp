using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public delegate bool UpdateGroupAndProject(int p_id);
    public class ProjectMember : User
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public int PMemberID { get; set; }
        public int PGroupID { get; set; }
        public int Project_ID { get; set; }

        public List<ProjectTask> tasks { get; set; } = new List<ProjectTask>();

        private static DataTable dt = new DataTable();

        public bool VerifyMail(string mail)
        {
            if (Regex.IsMatch(mail, pattern))
            {
                return true;
            }
            return false;

        }
        public bool CheckDuplicateMailAndPass(string mail, string pass)
        {
            string query = $"select * from PMember_TBL where " +
                $"PMember_Email = '{mail}' or PMember_Password = '{pass}';";
            FillTable(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public bool SearchMember(string mail)
        {
            string query = $"select * from PMember_TBL where " +
                $"PMember_Email = '{mail}';";
            FillTable(query);
            if (dt.Rows.Count == 1)
            {
                this.PMemberID = Convert.ToInt32(dt.Rows[0]["PMember_ID"].ToString());
                this.FirstName = dt.Rows[0]["PMember_FirstName"].ToString();
                this.LastName = dt.Rows[0]["PMember_LastName"].ToString();
                this.Email = dt.Rows[0]["PMember_Email"].ToString();
                this.password = dt.Rows[0]["PMember_Password"].ToString();
                return true;
            }
            return false;
        }
        private void FillTable(string query)
        {
            dt.Clear();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
        }
        public bool RunQuery(string query)
        {
            bool ret = false;
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public bool GetMemberPass(string mail)
        {
            string query = $"select PMember_Password from PMember_TBL where" +
                $" PMember_Email = '{mail}'";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                password = (string)cmd.ExecuteScalar();

            }
            if (!string.IsNullOrWhiteSpace(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetMemberID()
        {
            int val = 100;
            string query = $"select * from PMember_TBL where " +
                $"PMember_Email = '{this.Email}' AND " +
                $"PMember_Password = '{this.password}';";
            FillTable(query);
            if (dt.Rows.Count == 1)
            {
                val = Convert.ToInt32(dt.Rows[0]["PMember_ID"].ToString());
            }
            return val;
        }
        public void GetProjectMemberFromTask(int t_id)
        {
            string query = $"select pm.* from PMember_TBL as pm,PerformTask_TBL as pt " +
                $"where pm.PMember_ID = pt.PMember_ID and pt.Task_ID = '{t_id}'";
            FillTable(query);

            if (dt.Rows.Count == 1)
            {
                this.PMemberID = Convert.ToInt32(dt.Rows[0]["PMember_ID"].ToString());
                this.FirstName = dt.Rows[0]["PMember_FirstName"].ToString();
                this.LastName = dt.Rows[0]["PMember_LastName"].ToString();
                this.Email = dt.Rows[0]["PMember_Email"].ToString();
                this.password = dt.Rows[0]["PMember_Password"].ToString();
            }
        }
        public bool SignUPProjectMember(string firstName, string LastName,
        string email, string password)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Email = email;
            this.password = password;
            string query = $"insert into PMember_TBL " +
            $"(PMember_FirstName, PMember_LastName, PMember_Email, PMember_Password) " +
                $"values('{firstName}', '{LastName}', '{email}', '{password}')";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                PMemberID = GetMemberID();
                return true;
            }

        }
        public bool SignInProjectMember(string email, string password)
        {

            string query = $"select * from PMember_TBL where " +
                $"PMember_Email = '{email}' AND " +
                $"PMember_Password = '{password}';";
            FillTable(query);

            if (dt.Rows.Count == 1)
            {
                this.PMemberID = Convert.ToInt32(dt.Rows[0]["PMember_ID"].ToString());
                this.FirstName = dt.Rows[0]["PMember_FirstName"].ToString();
                this.LastName = dt.Rows[0]["PMember_LastName"].ToString();
                this.Email = dt.Rows[0]["PMember_Email"].ToString();
                this.password = dt.Rows[0]["PMember_Password"].ToString();
                return true;
            }
            return false;
        }

        public void SaveGroupInfo(int g_id)
        {

            string query = $"insert into PMemberGroupInfo_TBL " +
                $"(PMember_ID,PMember_FirstName, PMember_LastName, PMember_Email, PMember_Password,PGroup_ID) " +
                $" values ('{this.PMemberID}','{this.FirstName}', '{this.LastName}', '{this.Email}', '{this.password}','{g_id}') ";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void SaveProjectInfo(int proj_id)
        {

            string query = $"insert into PMemberProjectInfo_TBL " +
                $"(PMember_ID,PMember_FirstName, PMember_LastName, PMember_Email, PMember_Password,Project_ID) " +
                $" values ('{this.PMemberID}','{this.FirstName}', '{this.LastName}', '{this.Email}', '{this.password}','{proj_id}') ";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool CheckifGroupMember(int pm_id)
        {
            string query = $"select * from PMemberGroupInfo_TBL where " +
                $"PMember_ID = '{pm_id}';";
            FillTable(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;

        }
        public bool CheckifGroupMember(int pm_id, int group_id)
        {
            string query = $"select * from PMemberGroupInfo_TBL where " +
                $"PMember_ID = '{pm_id}' and PGroup_ID = '{group_id}';";
            FillTable(query);
            if (dt.Rows.Count == 1)
            {
                this.PMemberID = Convert.ToInt32(dt.Rows[0]["PMember_ID"].ToString());
                this.FirstName = dt.Rows[0]["PMember_FirstName"].ToString();
                this.LastName = dt.Rows[0]["PMember_LastName"].ToString();
                this.Email = dt.Rows[0]["PMember_Email"].ToString();
                this.password = dt.Rows[0]["PMember_Password"].ToString();
                return true;
            }
            return false;
        }

        public List<ProjectTask> GetTaskList(int pm_id)
        {
            ProjectTask task = new ProjectTask();
            DataTable dt = task.CheckAssingedToMember(pm_id);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    task = new ProjectTask();
                    task.Task_ID = Convert.ToInt32(dr["Task_ID"].ToString());
                    task.Task_Title = dr["Task_title"].ToString();
                    task.Task_Desc = dr["Task_Desc"].ToString();
                    task.Task_Completed = Convert.ToInt32(dr["Task_Completed"].ToString());

                    task.Task_Comment = dr["Task_Comment"].ToString();
                    tasks.Add(task);

                }

            }

            return tasks;

        }
        public bool UpdateTask(int task_id, byte[] attachedFile)
        {
            bool performTask = false;
            bool assignTask = false;
            bool taskComplete = false;
            ProjectTask task = tasks.Find(x => x.Task_ID == task_id);
            string query = $"update PerformTask_TBL " +
                $"set Task_Attached = @fileData,Task_Comment = '{task.Task_Comment}'," +
                $"Task_Completed = {task.Task_Completed}" +
                $" where task_id = '{task_id}';";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@fileData", SqlDbType.VarBinary).Value = attachedFile;
                cmd.Connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    performTask = true;
                }
            }
            string query1 = $"update AssignTask_TBL " +
                $"set Task_Completed = {task.Task_Completed}" +
                $" where task_id = {task_id}";
            assignTask = RunQuery(query1);
            string query2 = $"update Task_TBL " +
                $"set Task_Completed = {task.Task_Completed}" +
                $" where task_id = {task_id}";
            taskComplete = RunQuery(query2);
            if (performTask && assignTask && taskComplete)
            {
                return true;
            }
            return false;
        }

        public void RemoveTaskComplete(int task_id)
        {

            ProjectTask task = tasks.Find(x => x.Task_ID == task_id);
            string query = $"update PerformTask_TBL " +
                $"set Task_Attached = null,Task_Comment = null," +
                $"Task_Completed = 1" +
                $" where task_id = '{task_id}';";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public bool UpdateMemberInfo()
        {
            int rowEffected = 0;
            string query = $"update PMember_TBL " +
                $" set PMember_FirstName = '{this.FirstName}',PMember_LastName = '{this.LastName}'" +
                $",PMember_Email = '{this.Email}',PMember_Password = '{this.password}' " +
                $"where PMember_ID = {this.PMemberID}";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowEffected = cmd.ExecuteNonQuery();
            }
            if (rowEffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteMemberGroupInfoTable(int pm_id)
        {
            int rowEffected = 0;
            string query = $"delete from PMemberGroupInfo_TBL where " +
                $"PMember_ID = {pm_id}";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowEffected = cmd.ExecuteNonQuery();
            }
            if (rowEffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteMemberProjInfoTable(int pm_id)
        {
            int rowEffected = 0;
            string query = $"delete from PMemberProjectInfo_TBL where " +
                $"PMember_ID = {pm_id}";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowEffected = cmd.ExecuteNonQuery();
            }
            if (rowEffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteMemberAssignedTask(int p_id)
        {
            int rowsEffected = 0;
            string query = $"delete ptt from PerformTask_TBL ptt Inner join Task_TBL tt on ptt.Task_ID = tt.Task_ID where tt.Project_ID = {p_id}";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }
            if (rowsEffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMemberGroupInfoTable(int pm_id, int g_id)
        {
            int rowEffected = 0;
            string query = $"update PMemberGroupInfo_TBL" +
                $" set PGroup_ID = '{g_id}' where " +
                $"PMember_ID = '{pm_id}'";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowEffected = cmd.ExecuteNonQuery();
            }
            if (rowEffected == 1)
            {
                return true;
            }

            return false;

        }
        public bool UpdateProjectGroupInfoTable(int pm_id, int p_id)
        {
            int rowEffected = 0;
            string query = $"update PMemberProjectInfo_TBL" +
                $" set Project_ID = '{p_id}' where " +
                $"PMember_ID = '{pm_id}'";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowEffected = cmd.ExecuteNonQuery();
            }
            if (rowEffected == 1)
            {
                return true;
            }

            return false;

        }
        public bool AssignTask(int t_id, int pM_id)
        {
            string query = $"update PerformTask_TBL " +
                $" set PMember_ID = '{pM_id}' where " +
                $"Task_ID = '{t_id}'";
            return RunQuery(query);
        }

    }
}
