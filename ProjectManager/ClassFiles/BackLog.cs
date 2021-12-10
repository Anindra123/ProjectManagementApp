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
        /// Inserts a project task that has been completed 
        /// for a particular project and group its data to backlog
        /// </summary>
        public bool InsertBackLogData()
        {
            string query = $"insert into BackLog " +
                $"(BackLog_ProjectTitle,BackLog_GroupName,BackLog_Tasktitle,BackLog_TaskCompletedby,PManager_ID)" +
                $" values('{BackLog_ProjectTitle}','{BackLog_GroupName}','{BackLog_TaskTitle}','{BackLog_TaskCompleted}','{PManager_ID}')";
            return RunQuery(query);
        }
        /// <summary>
        /// Retrives backlog data from database
        /// </summary>
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
