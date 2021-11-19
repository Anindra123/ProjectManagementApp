using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class DBConnection
    {

        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Fall 21-22\OOP 2\Project\ProjectManagerApp\DB Files\ProjectManagerDB.mdf"";Integrated Security=True;Connect Timeout=30";
        public static string GetConnString()
        {
            return connectionString;
        }
    }
}
