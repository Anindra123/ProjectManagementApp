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

    public partial class ProjectManagementStartForm : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        public ProjectManagementStartForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(adminLoginBtn, "Administrator");
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }



        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void quitApplicationBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignInForm signIn = new SignInForm();
            ShowNewMenu(signIn);
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLogin = new AdminLoginForm();
            ShowNewMenu(adminLogin);
        }
    }
}
