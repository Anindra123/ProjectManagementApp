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

        public bool SearchGroup(string name)
        {
            string query = $"select * from GroupContainsProject_TBL where " +
                $"PGroup_Name = '{name}'";
            using (SqlConnection cnn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
                sda.Fill(dt);
            }
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

        public void GetPManagerTitleForMember(int id)
        {

        }

    }
}
