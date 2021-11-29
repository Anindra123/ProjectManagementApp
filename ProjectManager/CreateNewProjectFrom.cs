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

        private void proMProjTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proM2Confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Name Required", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void proMProjTitleTextBox_Leave(object sender, EventArgs e)
        {



        }

        private void CreateNewProjectFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
