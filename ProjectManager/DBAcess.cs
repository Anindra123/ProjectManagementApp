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


        private static DataTable dt = new DataTable();

        private static void FillTable(string query)
        {
            dt.Clear();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
            }
        }
        public static bool SignUPProjectMember(string firstName, string LastName,
            string email, string password)
        {
            string query = $"insert into PMember_TBL " +
            $"(PMember_FirstName, PMember_LastName, PMember_Email, PMember_Password) " +
                $"values('{firstName}', '{LastName}', '{email}', '{password}')";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static ProjectMember SignInProjectMember(string email, string password)
        {

            string query = $"select * from PMember_TBL where " +
                $"PMember_Email = '{email}' AND " +
                $"PMember_Password = '{password}';";
            ProjectMember member = new ProjectMember();
            FillTable(query);

            if (dt.Rows.Count > 0)
            {
                member.PMemberID = Convert.ToInt32(dt.Rows[0]["PMember_ID"].ToString());
                member.FirstName = dt.Rows[0]["PMember_FirstName"].ToString();
                member.LastName = dt.Rows[0]["PMember_LastName"].ToString();
                member.Email = dt.Rows[0]["PMember_Email"].ToString();
                member.password = dt.Rows[0]["PMember_Password"].ToString();
            }
            return member;
        }


        public static bool SignIn(string email, string pass)

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
                pM.PManager_ID = Convert.ToInt32(dtbl.Rows[0]["PManager_ID"].ToString());
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
