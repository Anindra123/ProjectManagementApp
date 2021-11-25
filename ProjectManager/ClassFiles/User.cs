using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
    }
}
