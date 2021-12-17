using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class PUserType
    {
        public int PUser_ID { get; set; }
        public string PUser_Type { get; set; }

        public static string GetUserType(int id)
        {
            string ret = null;
            string query = $"select PUser_Type from " +
                $" PUserType where PUser_ID = '{id}'";
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
