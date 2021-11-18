using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class Project
    {
        public int Project_ID { get; set; }
        public string Project_Title { get; set; }
        public string Project_Desc { get; set; }
        public DateTime Project_StartDate { get; set; }
        public DateTime Project_EndDate { get; set; }
        public bool Project_Completed { get; set; }
        public int PManager_ID { get; set; }

    }
}
