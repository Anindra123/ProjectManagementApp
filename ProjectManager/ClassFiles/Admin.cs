using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class Admin : User
    {
        public bool SignIn()
        {
            string query = $"select * from Admin_TBL where " +
                $" Admin_Name = '{FirstName}' and Admin_Password = '{password}'";
            FillData(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateUserStatus(int status)
        {
            string query = $"update user_tbl " +
                $"set puserstatus_id = {status} where" +
                $" user_id = {UserID}";
            return RunQuery(query);
        }
    }
}
