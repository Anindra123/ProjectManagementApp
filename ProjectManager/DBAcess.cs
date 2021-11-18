using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectManager
{
    class DBAcess
    {
        public static bool SignIn(string email,string pass)
        {
            bool ret = false;
            SqlConnection sqlConn = new SqlConnection(DBConnection.GetConnString());
            ProjectManager pM = new ProjectManager();
            sqlConn.Open();
            string query = $"SELECT * FROM  PManager_TBL WHERE PManager_Email ='{email}' AND PManager_Password = '{pass}'"; 
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                pM.PManager_ID = Convert.ToInt32(dtbl.Rows[0]["PMananger_ID"].ToString());
                pM.FirstName = (string)dtbl.Rows[0]["PManager_FirstName"];
                pM.LastName = (string)dtbl.Rows[0]["PManager_LastName"];
                pM.Email = (string)dtbl.Rows[0]["PManager_Email"];
                pM.password = (string)dtbl.Rows[0]["PManager_Password"];

                ret = true;
            }

            sqlConn.Close();
            return ret;
            
            
        }

       
    }
}
