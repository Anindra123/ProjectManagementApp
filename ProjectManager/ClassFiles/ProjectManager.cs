using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class ProjectManager : User
    {
        DataTable dt = new DataTable();
        public int PManager_ID { get; set; }
        public List<ProjectGroup> ProjectGroups { get; set; } = new List<ProjectGroup>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public void FillData(string query)
        {
            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
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
        public bool CheckDuplicateUpdate(string email, string pass)
        {
            string query = $"select * from PManager_TBL where " +
                $"(PManager_Email ='{email}' or PManager_Password = '{pass}')" +
                $" and PManager_ID != {PManager_ID};";
            FillData(query);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            return false;
        }
        public bool CheckDuplicateMailAndPass(string email, string pass)
        {
            string query = $"select * from PManager_TBL where " +
                $"PManager_Email ='{email}' or PManager_Password = '{pass}';";
            FillData(query);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            return false;
        }
        public bool UpdateProjectManagerInfo(string fName, string lName, string pass, string email)
        {

            string query = $"update PManager_TBL " +
                $"set PManager_FirstName = '{fName}',PManager_LastName = '{lName}'," +
                $"PManager_Password = '{pass}',PManager_Email = '{email}' " +
                $"where PManager_ID = {PManager_ID}";
            if (RunQuery(query))
            {
                return true;
            }
            return false;

        }
        public bool AssignGroup(string gName, int pM_ID)
        {
            string query = $"select * from PGroup_TBL where PGroup_name = '{gName}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                query = $"insert into PManagerGroupInfo_TBL" +
                     $" (PGroup_ID,PGroup_Name,PGroup_MembersCount,PManager_ID) " +
                     $"values ('{dt.Rows[0]["PGroup_ID"]}'," +
                     $"'{dt.Rows[0]["PGroup_Name"]}','{dt.Rows[0]["PGroup_MembersCount"]}','{pM_ID}')";
                if (RunQuery(query))
                {
                    return true;
                }
            }
            return false;
        }
        public bool AssignProject(string pTitle, int pM_ID, string gName)
        {
            bool assignToPManager = false;
            bool assignToGroup = false;
            int Proj_ID = 0;
            string query = $"select * from Project_TBL where Project_Title = '{pTitle}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                Proj_ID = Convert.ToInt32($"{dt.Rows[0]["Project_ID"]}");
                query = $"insert into ManageProject_TBL" +
                       $" (Project_ID,Project_Title,Project_Desc,Project_StartDate,Project_EndDate,PStatus_ID,PManager_ID) " +
                       $"values ('{dt.Rows[0]["Project_ID"]}','{dt.Rows[0]["Project_Title"]}','{dt.Rows[0]["Project_Desc"]}'" +
                       $",'{dt.Rows[0]["Project_StartDate"]}','{dt.Rows[0]["Project_EndDate"]}','{dt.Rows[0]["PStatus_ID"]}','{pM_ID}')";
                if (RunQuery(query))
                {
                    assignToPManager = true;
                }
            }
            query = $"select * from PGroup_TBL where PGroup_name = '{gName}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                query = $"insert into GroupContainsProject_TBL" +
                       $" (PGroup_ID,PGroup_Name,PGroup_MembersCount,Project_ID) " +
                       $"values ('{dt.Rows[0]["PGroup_ID"]}'," +
                       $"'{dt.Rows[0]["PGroup_Name"]}','{dt.Rows[0]["PGroup_MembersCount"]}','{Proj_ID}')";
                if (RunQuery(query))
                {
                    assignToGroup = true;
                }
            }
            if (assignToGroup && assignToPManager)
            {
                return true;
            }
            return false;
        }
        public bool CreateGroup(string gName, int membersCount)
        {
            string query = $"insert into PGroup_TBL" +
                $" (PGroup_name,PGroup_MembersCount) " +
                $"values('{gName}','{membersCount}')";
            if (RunQuery(query))
            {
                return true;
            }
            return false;
        }
        public bool CreateProject(string pTitle, string pDesc, DateTime sDate, DateTime eDate)
        {
            string query = $"insert into Project_TBL" + $" (Project_Title,Project_Desc,Project_StartDate,Project_EndDate,PStatus_ID)" + $" values('{pTitle}','{pDesc}','{sDate}','{eDate}','2')";
            if (RunQuery(query))
            {
                return true;
            }
            return false;
        }
        public void GetProjectManager()
        {
            string query = $"select * from PManager_TBL where PManager_ID = {PManager_ID}";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                FirstName = $"{dt.Rows[0]["PManager_FirstName"]}";
                LastName = $"{dt.Rows[0]["PManager_LastName"]}";
                Email = $"{dt.Rows[0]["PManager_Email"]}";
                password = $"{dt.Rows[0]["PManager_Password"]}";

            }
        }
        public void AddGroupMembers(List<ProjectMember> pMList, int g_id)
        {
            foreach (ProjectMember item in pMList)
            {
                string query = $"insert into PMemberGroupInfo_TBL " +
                    $"(PMember_ID,PMember_FirstName,PMember_LastName,PMember_Password,PMember_Email,PGroup_ID)" +
                    $" values ('{item.PMemberID}','{item.FirstName}','{item.LastName}','{item.password}','{item.Email}','{g_id}')";
                RunQuery(query);
            }
        }
        public void AddProjectMembers(List<ProjectMember> pMList, int p_id)
        {
            foreach (ProjectMember item in pMList)
            {
                string query = $"insert into PMemberProjectInfo_TBL " +
                    $"(PMember_ID,PMember_FirstName,PMember_LastName,PMember_Password,PMember_Email,Project_ID)" +
                    $" values ('{item.PMemberID}','{item.FirstName}','{item.LastName}','{item.password}','{item.Email}','{p_id}')";
                RunQuery(query);
            }
        }
        public void GetProjectGroups()
        {
            ProjectGroups.Clear();
            string query = $"select pg.* from PGroup_TBL as pg, PManagerGroupInfo_TBL as pmg " +
                $"where pg.PGroup_ID = pmg.PGroup_ID and pmg.PManager_ID = '{PManager_ID}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ProjectGroup pG = new ProjectGroup();
                    pG.PGroup_ID = Convert.ToInt32($"{row["PGroup_ID"]}");
                    pG.PGroup_Name = $"{row["PGroup_name"]}";
                    pG.MembersCount = Convert.ToInt32($"{row["PGroup_MembersCount"]}");
                    ProjectGroups.Add(pG);
                }
            }

        }
        public ProjectMember SearchPMember(string mail)
        {
            ProjectMember output = new ProjectMember();
            string query = $"Select * from PMember_TBL where " +
                $"PMember_Email = '{mail}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                output.PMemberID = Convert.ToInt32($"{dt.Rows[0]["PMember_ID"]}");
                output.FirstName = $"{dt.Rows[0]["PMember_FirstName"]}";
                output.LastName = $"{dt.Rows[0]["PMember_LastName"]}";
                output.Email = $"{dt.Rows[0]["PMember_Email"]}";
                output.password = $"{dt.Rows[0]["PMember_Password"]}";
            }
            else
            {
                output = null;
            }
            return output;
        }
        public bool CheckIfAlreadyGroupMember(int pmember_id)
        {
            string query = $"select * from PMemberGroupInfo_TBL where " +
                $"PMember_ID = '{pmember_id}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public void FillPmemberData(DataTable dt, int pmember_id)
        {
            string query = $"select Concat(PMember_FirstName,' ',PMember_LastName) as Name,PMember_Email as Email from" +
                $" PMember_TBL where PMember_ID = {pmember_id}";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
        }
        public void GetProjects()
        {
            Projects.Clear();
            string query = $"select p.* from ManageProject_TBL mp, Project_TBL as p " +
              $"where p.Project_ID = mp.Project_Id and mp.PManager_ID = '{PManager_ID}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Project pr = new Project();
                    pr.Project_ID = Convert.ToInt32($"{row["Project_ID"]}");
                    pr.Project_Title = $"{row["Project_Title"]}";
                    pr.Project_Desc = $"{row["Project_Desc"]}";
                    pr.Project_StartDate = Convert.ToDateTime($"{row["Project_StartDate"]}");
                    pr.Project_EndDate = Convert.ToDateTime($"{row["Project_EndDate"]}");
                    Projects.Add(pr);
                }
            }

        }
        public Project GetProject(int g_id)
        {
            Project output = new Project();
            string query = $"select p_t.* from GroupContainsProject_TBL as gcp_t " +
                $", Project_TBL as p_t where gcp_t.PGroup_ID = '{g_id}' and p_t.Project_ID = " +
                $" gcp_t.Project_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                output.Project_ID = Convert.ToInt32(dt.Rows[0]["Project_ID"].ToString());
                output.Project_Title = dt.Rows[0]["Project_Title"].ToString();
                output.Project_Desc = dt.Rows[0]["Project_Desc"].ToString();
                output.Project_StartDate = Convert.ToDateTime(dt.Rows[0]["Project_StartDate"].ToString());
                output.Project_EndDate = Convert.ToDateTime(dt.Rows[0]["Project_EndDate"].ToString());
                output.Project_Completed = Convert.ToInt32(dt.Rows[0]["PStatus_ID"].ToString());

            }
            else
            {
                output = null;
            }
            return output;
        }
        public DataTable ViewProjectGroupInfo()
        {
            string query = $"select pmg.PGroup_Name as [Group Name],mp.Project_Title as [Project Title],mp.Project_StartDate as [Start Date],mp.Project_EndDate as [End Date] " +
                $"from PManagerGroupInfo_TBL as pmg,ManageProject_TBL as mp,GroupContainsProject_TBL as gcp where " +
                $"pmg.PManager_ID = '{PManager_ID}' and gcp.PGroup_ID = pmg.PGroup_ID and " +
                $"mp.Project_ID = gcp.Project_ID ";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public bool SignIn(string email, string pass)

        {
            bool ret = false;
            SqlConnection sqlConn = new SqlConnection(DBConnection.GetConnString());

            sqlConn.Open();
            string query = $"SELECT * FROM  PManager_TBL WHERE PManager_Email ='{email}' AND PManager_Password = '{pass}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {

                PManager_ID = Convert.ToInt32(dtbl.Rows[0]["PManager_ID"].ToString());
                FirstName = (string)dtbl.Rows[0]["PManager_FirstName"];
                LastName = (string)dtbl.Rows[0]["PManager_LastName"];
                Email = (string)dtbl.Rows[0]["PManager_Email"];
                password = (string)dtbl.Rows[0]["PManager_Password"];



                ret = true;
            }

            sqlConn.Close();
            return ret;


        }
        public bool CheckTaskExist(string taskTitle)
        {
            string query = $"select * from Task_TBL where Lower(Task_title) = '{taskTitle}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public int GetTaskID(string taskTitle)
        {
            string query = $"select * from Task_TBL where Lower(Task_title) = '{taskTitle}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                return Convert.ToInt32($"{dt.Rows[0]["Task_ID"]}");
            }
            return -1;
        }
        public bool CreateTask(string taskTitle, string taskDesc, int p_id)
        {


            string query = $"insert into Task_TBL " +
                $"(Task_title,Task_Desc,Task_Completed,Project_ID) " +
                $"values('{taskTitle}','{taskDesc}','1','{p_id}')";
            return RunQuery(query);

        }
        public bool AssignTask(string taskTitle, string taskDesc, int pM_id)
        {
            if (GetTaskID(taskTitle) > 0)
            {
                int t_id = GetTaskID(taskTitle);
                string query = $"insert into AssignTask_TBL " +
                $"(Task_ID,Task_title,Task_Desc,Task_Completed,PManager_ID) " +
                $"values('{t_id}','{taskTitle}','{taskDesc}','1','{pM_id}')";
                return RunQuery(query);
            }
            return false;
        }
        public bool AssignTaskToMember(string taskTitle, string taskDesc, int pMem_id)
        {
            if (GetTaskID(taskTitle) > 0)
            {
                string query;
                int t_id = GetTaskID(taskTitle);
                if (pMem_id > 0)
                {
                    query = $"insert into PerformTask_TBL " +
                 $"(Task_ID,Task_title,Task_Desc,Task_Completed,PMember_ID) " +
                 $"values('{t_id}','{taskTitle}','{taskDesc}','1','{pMem_id}')";
                }
                else
                {
                    query = $"insert into PerformTask_TBL " +
                $"(Task_ID,Task_title,Task_Desc,Task_Completed,PMember_ID) " +
                $"values('{t_id}','{taskTitle}','{taskDesc}','1',NULL)";
                }
                return RunQuery(query);
            }
            return false;
        }
        public DataTable ViewCurrentTask(int pM_id)
        {
            string query = $"select at.Task_ID as ID,at.Task_title as Title,at.Task_Desc as Description,ts.StatusName as Status from" +
                $" AssignTask_TBL as at,TaskStatus_TBL as ts" +
                $" where at.PManager_ID = '{pM_id}' and at.Task_Completed = '1' and ts.StatusID = at.Task_Completed ";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public DataTable ViewCompletedTask(int pM_id)
        {
            string query = $"select at.Task_ID as ID,at.Task_title as Title,at.Task_Desc as Description,ts.StatusName as Status from" +
               $" AssignTask_TBL as at,TaskStatus_TBL as ts" +
               $" where at.PManager_ID = '{pM_id}' and at.Task_Completed = '2' and ts.StatusID = at.Task_Completed ";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }

        public bool SignUp(string firstName, string lastName, string email, string password)
        {
            bool ret = false;
            string query = $"INSERT INTO PManager_TBL (PManager_FirstName, PManager_LastName, PManager_Email, PManager_Password)" +
                    $"  VALUES ('{firstName}','{lastName}','{email}','{password}')";
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
        public void GetProjectManagerTitleForMember(int id)
        {
            string query = $"select pm.* from ManageProject_TBL as mp " +
                $", PManager_TBL as pm where mp.Project_ID = '{id}' and pm.PManager_ID = " +
                $" mp.PManager_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                FirstName = dt.Rows[0]["PManager_FirstName"].ToString();
                LastName = dt.Rows[0]["PManager_LastName"].ToString();

            }
        }
        public void GetProjectManagerInfo(int proj_id)
        {
            string query = $"select pm.* from ManageProject_TBL as mp," +
                $"PManager_TBL as pm where mp.Project_ID = {proj_id} " +
                $"and pm.PManager_ID = mp.PManager_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                PManager_ID = Convert.ToInt32(dt.Rows[0]["PManager_ID"].ToString());
                FirstName = dt.Rows[0]["PManager_FirstName"].ToString();
                LastName = dt.Rows[0]["PManager_LastName"].ToString();
                Email = dt.Rows[0]["PManager_Email"].ToString();
                password = dt.Rows[0]["PManager_Password"].ToString();
            }

        }

    }
}
