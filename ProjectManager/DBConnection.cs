using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class DBConnection
    {

        static string connectionString = @"";
        public static string GetConnString()
        {
            return connectionString;
        }
    }
}
