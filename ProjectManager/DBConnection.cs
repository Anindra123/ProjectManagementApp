using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class DBConnection
    {
<<<<<<< HEAD
        //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Fall 21-22\OOP 2 Lab Task\Week10HomePrac\DB Files\ProjectManagerDB.mdf"";Integrated Security=True;Connect Timeout=30";
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""S:\Projects\ProjectManagerApp\DB Files\ProjectManagerDB.mdf"";Integrated Security=True;Connect Timeout=30";
=======
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Fall 21-22\OOP 2\Project\ProjectManagerApp\DB Files\ProjectManagerDB.mdf"";Integrated Security=True;Connect Timeout=30";

>>>>>>> BivasBranch
        public static string GetConnString()
        {
            return connectionString;
        }
    }
}
