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
        public int PManager_ID { get; set; }
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
        public void GetProjectGroup(int t_id)
        {
            ProjectGroup output = new ProjectGroup();
            string query = $"select gcp.PGroup_ID,gcp.PGroup_Name from " +
                $"GroupContainsProject_TBL as gcp,Task_TBL as tt where " +
                $"tt.Task_ID = '{t_id}' and gcp.Project_ID = tt.Project_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                PGroup_ID = Convert.ToInt32($"{dt.Rows[0]["PGroup_ID"]}");
                PGroup_Name = $"{dt.Rows[0]["PGroup_Name"]}";
            }
        }

    }
}
