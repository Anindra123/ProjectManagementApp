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
        public void GetProjectInfo(int pmember_id)
        {
            string query = $"select p_t.* from PMemberProjectInfo_TBL as pmp_t " +
                $", Project_TBL as p_t where pmp_t.PMember_ID = '{pmember_id}' and p_t.Project_ID = " +
                $" pmp_t.Project_ID";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                Project_ID = Convert.ToInt32(dt.Rows[0]["Project_ID"].ToString());
                Project_Title = dt.Rows[0]["Project_Title"].ToString();
                Project_Desc = dt.Rows[0]["Project_Desc"].ToString();
                Project_StartDate = Convert.ToDateTime(dt.Rows[0]["Project_StartDate"].ToString());
                Project_EndDate = Convert.ToDateTime(dt.Rows[0]["Project_EndDate"].ToString());
                Project_Completed = Convert.ToInt32(dt.Rows[0]["PStatus_ID"].ToString());

            }
        }

    }
}
