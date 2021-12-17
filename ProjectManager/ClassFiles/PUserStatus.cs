using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class PUserStatus
    {
        public int PUserStatus_ID { get; set; }
        public string PUserStatus_Type { get; set; }

        public static string GetUserStatus(int id)
        {
            string ret = null;
            string query = $"select PUserStatus_Type from " +
                $" PUserStatus where PUserStatus_ID = '{id}'";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                ret = (string)cmd.ExecuteScalar();
            }
            return ret;
        }
    }
}
