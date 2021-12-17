using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public abstract class User
    {
        /// <summary>
        /// Inherited by ProjectManager and ProjectMember class
        /// and also admin class
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public string UserStatus { get; set; }
        public int UserID { get; set; }

        protected static DataTable dt = new DataTable();
        /// <summary>
        /// Common function 
        /// used to reset the datatable data and fill the datatable
        /// with new data
        /// </summary>
        public static void FillData(string query)
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
        public static bool CheckDuplicateMailPassName(string mail, string pass, string name)
        {
            string query = "select * from User_TBL where " +
                $"User_Email = '{mail}' or User_Password = '{pass}'" +
                $" or User_FirstName = '{name}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool CheckDuplicateMailPassName(string mail, string pass, string fname, string lname)
        {
            string query = "select * from User_TBL where " +
                $"User_Email = '{mail}' or User_Password = '{pass}'" +
                $" or User_FirstName = '{fname}' or User_LastName = '{lname}'";
            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool SignUp(string firstName, string lastName,
            string mail, string pass, int userType)
        {
            string query = $"insert into User_TBL " +
                $"(User_FirstName,User_LastName,User_Password,User_Email,PUser_ID,PUserStatus_ID)" +
                $" values ('{firstName}','{lastName}','{pass}','{mail}',{userType},1)";
            return RunQuery(query);
        }
        public static bool SignUp(string firstName,
            string mail, string pass, int userType)
        {
            string query = $"insert into User_TBL " +
                $"(User_FirstName,User_Password,User_Email,PUser_ID,PUserStatus_ID)" +
                $" values ('{firstName}','{pass}','{mail}',{userType},1)";
            return RunQuery(query);
        }
        public void FillUserInfo()
        {
            UserID = (int)dt.Rows[0]["User_ID"];
            FirstName = $"{dt.Rows[0]["User_FirstName"]}";
            if (dt.Rows[0]["User_LastName"] != null)
            {
                LastName = $"{dt.Rows[0]["User_LastName"]}";
            }
            else
            {
                LastName = null;
            }
            Email = $"{dt.Rows[0]["User_Email"]}";
            int puser_id = (int)dt.Rows[0]["PUser_ID"];
            int puserStatus_id = (int)dt.Rows[0]["PUserStatus_ID"];
            UserType = PUserType.GetUserType(puser_id);
            UserStatus = PUserStatus.GetUserStatus(puserStatus_id);
        }
        public void FillUserInfo(int id)
        {
            string query = $"select * from user_tbl where user_id = '{id}'";
            FillData(query);
            UserID = (int)dt.Rows[0]["User_ID"];
            FirstName = $"{dt.Rows[0]["User_FirstName"]}";
            if (dt.Rows[0]["User_LastName"] != null)
            {
                LastName = $"{dt.Rows[0]["User_LastName"]}";
            }
            else
            {
                LastName = null;
            }
            Email = $"{dt.Rows[0]["User_Email"]}";
            int puser_id = (int)dt.Rows[0]["PUser_ID"];
            int puserStatus_id = (int)dt.Rows[0]["PUserStatus_ID"];
            UserType = PUserType.GetUserType(puser_id);
            UserStatus = PUserStatus.GetUserStatus(puserStatus_id);
        }
        public static string GetTypeOfUser()
        {
            int puser_id = (int)dt.Rows[0]["PUser_ID"];
            return PUserType.GetUserType(puser_id);
        }
        public static bool SignIn(string email, string pass)
        {
            string query = "select * from user_tbl where " +
                $" user_email = '{email}' and user_password = '{pass}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public DataTable GetUserList()
        {
            string query = "select u.User_ID as [User ID],Concat(u.user_firstname,'',u.user_lastname) as [Full Name]," +
                "u.user_email as Email,pt.PUser_Type as Role,ps.PUserStatus_Type as Status from User_TBL as u,PUserType as pt," +
                "PUserStatus as ps where pt.PUser_ID = u.PUser_ID and ps.PUserStatus_ID = u.PUserStatus_ID ";

            FillData(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
