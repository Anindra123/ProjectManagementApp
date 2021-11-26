using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class ProjectMember : User
    {
        public int PMemberID { get; set; }
        public int PGroupID { get; set; }
        public int Project_ID { get; set; }
        public List<ProjectTask> tasks { get; set; } = new List<ProjectTask>();

        private static DataTable dt = new DataTable();

        private void FillTable(string query)
        {
            dt.Clear();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
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
        public bool UpdateTask(int task_id)
        {
            int rowsaffected = 0;
            ProjectTask task = tasks.Find(x => x.Task_ID == task_id);
            string query = $"update PerformTask_TBL " +
                $"set Task_Attached = convert(varbinary(max),'{task.Task_Attached}'),Task_Comment = '{task.Task_Comment}'," +
                $"Task_Completed = {task.Task_Completed}" +
                $" where task_id = '{task_id}';";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                rowsaffected = cmd.ExecuteNonQuery();
            }
            if (rowsaffected == 1)
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
    }
}
