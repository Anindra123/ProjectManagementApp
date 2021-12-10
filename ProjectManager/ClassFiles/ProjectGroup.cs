using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class ProjectGroup
    {
        DataTable dt = new DataTable();
        public int PGroup_ID { get; set; }
        public int MembersCount { get; set; }
        public string PGroup_Name { get; set; }
        public int Project_ID { get; set; }
        /// <summary>
        /// Common function 
        /// used to reset the datatable data and fill the datatable
        /// with new data
        /// </summary>
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
        /// <summary>
        /// Common function 
        /// used to open database connection and run executeNonQuery command
        /// and the number of rows effected boolean value is returned
        /// </summary>
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
        /// <summary>
        /// Searches group with group name and 
        /// retrives group information and assigns 
        /// values to the properties
        /// </summary>
        public bool SearchGroup(string name)
        {
            string query = $"select * from GroupContainsProject_TBL where " +
                $"PGroup_Name = '{name}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                MembersCount = Convert.ToInt32(dt.Rows[0]["PGroup_MembersCount"].ToString());
                PGroup_Name = dt.Rows[0]["PGroup_Name"].ToString();
                Project_ID = Convert.ToInt32(dt.Rows[0]["Project_ID"].ToString());
                PGroup_ID = Convert.ToInt32(dt.Rows[0]["PGroup_ID"].ToString());
                return true;
            }
            return false;
        }
        /// <summary>
        /// Retrives group information for 
        /// a particular project member
        /// </summary>
        public void GetPGroupInfo(int pmember_id)
        {
            string query = $"select pg.* from PMemberGroupInfo_TBL as pmg," +
                $"PGroup_TBL as pg where " +
                $"pmg.PMember_ID = '{pmember_id}' and pg.PGroup_ID = pmg.PGroup_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                PGroup_ID = Convert.ToInt32(dt.Rows[0]["PGroup_ID"].ToString());
                PGroup_Name = dt.Rows[0]["PGroup_Name"].ToString();
                MembersCount = Convert.ToInt32(dt.Rows[0]["PGroup_MembersCount"].ToString());

            }

        }
        /// <summary>
        /// Returns a data table of all the 
        /// member information that are currently in the 
        /// group , uses current group id
        /// </summary>
        public DataTable FillMemberList()
        {
            string query = $"select concat(pm.PMember_FirstName,' ',pm.PMember_LastName) as Name, pm.PMember_Email as Email from " +
                $"PMember_TBL as pm,PMemberGroupInfo_TBL as pmg where pmg.PGroup_ID = '{this.PGroup_ID}' " +
                $"and pmg.PMember_ID = pm.PMember_ID";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;

        }
        /// <summary>
        /// Returns a data table of all the 
        /// member information for a particular group
        /// </summary>
        public DataTable FillMemberList(int g_id)
        {
            string query = $"select pm.PMember_ID,concat(pm.PMember_FirstName,' ',pm.PMember_LastName) as Name, pm.PMember_Email as Email from " +
                $"PMember_TBL as pm,PMemberGroupInfo_TBL as pmg where pmg.PGroup_ID = '{g_id}' " +
                $"and pmg.PMember_ID = pm.PMember_ID";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;

        }
        /// <summary>
        /// Retrives and set the properties with 
        /// group information for a particular task
        /// </summary>
        public void GetProjectGroupFromTask(int t_id)
        {
            ProjectGroup output = new ProjectGroup();
            string query = $"select * from " +
                $"GroupContainsProject_TBL as gcp,Task_TBL as tt where " +
                $"tt.Task_ID = '{t_id}' and gcp.Project_ID = tt.Project_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                PGroup_ID = Convert.ToInt32($"{dt.Rows[0]["PGroup_ID"]}");
                PGroup_Name = $"{dt.Rows[0]["PGroup_Name"]}";
                MembersCount = Convert.ToInt32($"{dt.Rows[0]["PGroup_MembersCount"]}");
            }
        }
        /// <summary>
        /// Updates information for GroupContainsProject_TBL
        /// </summary>
        public bool UpdateGroupContainsProjectTable(string groupName, int memCount)
        {
            string query = $"Update GroupContainsProject_TBL" +
                $" set PGroup_name = '{groupName}',PGroup_MembersCount = '{memCount}' " +
                $"where PGroup_ID = {PGroup_ID}";
            return RunQuery(query);
        }
        /// <summary>
        /// Updates information for PManagerGroupInfo_TBL
        /// </summary>
        public bool UpdatePManagerGroupInfoTable(string groupName, int memCount)
        {
            string query = $"Update PManagerGroupInfo_TBL" +
                $" set PGroup_name = '{groupName}',PGroup_MembersCount = '{memCount}' " +
                $"where PGroup_ID = {PGroup_ID}";
            return RunQuery(query);
        }
        /// <summary>
        /// Updates information for PGroup_TBL
        /// </summary>
        public bool UpdatePGroupTable(string groupName, int memCount)
        {
            string query = $"Update PGroup_TBL" +
                $" set PGroup_name = '{groupName}',PGroup_MembersCount = '{memCount}' " +
                $"where PGroup_ID = {PGroup_ID}";
            return RunQuery(query);
        }
        /// <summary>
        /// Removes information from GroupContainsProject_TBL
        /// </summary>
        public bool RemoveGroupContainsProject()
        {
            string query = $"delete from GroupContainsProject_TBL where" +
                $" PGroup_ID = {PGroup_ID}";
            return RunQuery(query);
        }
        /// <summary>
        /// Removes information from PManagerGroupInfo_TBL
        /// </summary>
        public bool RemovePManagerGroupInfo()
        {
            string query = $"delete from PManagerGroupInfo_TBL where" +
                $" PGroup_ID = {PGroup_ID}";
            return RunQuery(query);
        }
        /// <summary>
        /// Removes information from PGroup_TBL
        /// </summary>
        public bool RemovePGroup()
        {
            string query = $"delete from PGroup_TBL where" +
                $" PGroup_ID = {PGroup_ID}";
            return RunQuery(query);
        }
    }
}

