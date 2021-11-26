using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class AssignTask : Form
    {
        public AssignTask()
        {
            InitializeComponent();
        }

        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectManagerView)Tag;
            form.Show();

        }

        private void SBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void AssignTaskBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
