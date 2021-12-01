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
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
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
            bool ret = false;
            string query = $"update PManager_TBL " +
                $"set PManager_FirstName = '{fName}',PManager_LastName = '{lName}'," +
                $"PManager_Password = '{pass}',PManager_Email = '{email}' " +
                $"where PManager_ID = {PManager_ID}";
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
        public void GetProjectGroups()
        {
            ProjectGroups.Clear();
            string query = $"select * from PManagerGroupInfo_TBL " +
                $"where PManager_ID = '{PManager_ID}'";
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
        public void GetProjects()
        {
            Projects.Clear();
            string query = $"select * from ManageProject_TBL " +
              $"where PManager_ID = '{PManager_ID}'";
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
        public DataTable ViewProjectGroupInfo()
        {
            string query = $"select pmg.PGroup_name as Group Name,mp.Project_Title as Project Title,mp.Project_StartDate as Start Date,mp.Project_EndDate as End Date from " +
                $"GroupContainsProject_TBL as gcp,ManagerProject_TBL as mp,PManagerGroupInfo_TBL as pmg " +
                $"where mp.PManager_ID = '{PManager_ID}' and pmg.PManager_ID = '{PManager_ID}'" +
                $"and gcp.PGroup_ID = pmg.PGroup_ID and gcp.Project_ID = mp.Project_ID; ";
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
