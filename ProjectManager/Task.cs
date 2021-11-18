using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class Task
    {
        public int Task_ID { get; set; }
        public string Task_Title { get; set; }
        public string Task_Desc { get; set; }
        public bool Task_Completed { get; set; }
        public DateTime Task_CompleteDate { get; set; }
        public string Task_Comment { get; set; }
        public int PManager_ID { get; set; }
        public int Project_ID { get; set; }
        public int PMember_ID { get; set; }

    }
}
