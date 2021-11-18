using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class ProjectGroup
    {
        public int PGroup_ID { get; set; }
        public int MembersCount { get; set; }
        public string PGroup_Name { get; set; }
        public int Project_ID { get; set; }
        public int PManager_ID { get; set; }

    }
}
