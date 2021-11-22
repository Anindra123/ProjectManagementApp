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
    public partial class CreateNewProjectFrom : Form
    {
        public CreateNewProjectFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void proM2Cancel_Click(object sender, EventArgs e)
        {
            var form1 = (ProjectManagerSignUpForm)Tag;
            this.Close();
            form1.Show();
        }
    }
}
