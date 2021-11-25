using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class Project
    {
        DataTable dt = new DataTable();
        public int Project_ID { get; set; }
        public string Project_Title { get; set; }
        public string Project_Desc { get; set; }
        public DateTime Project_StartDate { get; set; }
        public DateTime Project_EndDate { get; set; }
        public int Project_Completed { get; set; }
        public int PManager_ID { get; set; }

        public void FillData(string query)
        {
            dt.Clear();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
        }
        public void GetProjectTitleForMember(int id)
        {
            string query = $"select p.* from GroupContainsProject_TBL as pg " +
                $", Project_TBL as p where pg.PGroup_ID = '{id}' and p.Project_ID = " +
                $" pg.Project_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                Project_ID = Convert.ToInt32(dt.Rows[0]["Project_ID"].ToString());
                Project_Title = dt.Rows[0]["Project_Title"].ToString();
            }

        }

    }
}
