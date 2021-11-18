using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class ProjectMember : User
    {
        public int PMemberID { get; set; }
        public int PGroupID { get; set; }
        public int Project_ID { get; set; }
    }
}
