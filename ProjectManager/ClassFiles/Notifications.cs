using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class Notifications
    {

        public string Message { get; set; }
        public int UserID { get; set; }

        DataTable dt = new DataTable();
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
        public static bool RunQuery(string query)
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
        public void SetNewNotification()
        {
            string query = "insert into notifications " +
                "(Notification_Message,u_id) " +
                $"values('{Message}',{UserID})";
            RunQuery(query);
        }
        public DataTable GetNotifications(int id)
        {
            string query = "select Notification_Message as Message from notifications where " +
                $"u_id = {id}";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
