using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class BackLog
    {
        DataTable dt = new DataTable();
        public int BackLog_ID { get; set; }
        public string BackLog_ProjectTitle { get; set; }
        public string BackLog_GroupName { get; set; }
        public string BackLog_TaskTitle { get; set; }
        public string BackLog_TaskCompleted { get; set; }
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
        public bool InsertBackLogData()
        {
            string query = $"insert into BackLog " +
                $"(BackLog_ProjectTitle,BackLog_GroupName,BackLog_Tasktitle,BackLog_TaskCompletedby,PManager_ID)" +
                $" values('{BackLog_ProjectTitle}','{BackLog_GroupName}','{BackLog_TaskTitle}','{BackLog_TaskCompleted}','{PManager_ID}')";
            return RunQuery(query);
        }
        public DataTable GetBackLogData()
        {
            string query = "select BackLog_GroupName as [Group Name],BackLog_ProjectTitle as [Project Title]," +
                "BackLog_TaskTitle as [Task Title],BackLog_TaskCompletedby as [Completed By] from " +
                $"BackLog where PManager_ID = {PManager_ID}";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
