using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ProjectManagement
{
    public partial class ProjectManagerSignIn : Form
    {
        ProjectManagement.ClassFiles.ProjectManager pm = new ProjectManagement.ClassFiles.ProjectManager();
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public ProjectManagerSignIn()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ContinueAsProjectManagerForm)Tag;
            form.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void ProjectManagerSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        //[TO DO] - implement text feild validation
        // validate manager password and name/mail
        private void projMSignInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projMEmailTextBox.Text) || string.IsNullOrEmpty(projMPasswordTextBox.Text))
            {
                MessageBox.Show("Fill up all the fields");
            }
            else if (!Regex.IsMatch(projMEmailTextBox.Text, pattern))
            {
                MessageBox.Show("Invalid Email Format");
            }
            else
            {

                bool ret = pm.SignIn(projMEmailTextBox.Text.Trim(), projMPasswordTextBox.Text.Trim());

                if (ret == true)
                {

                    ProjectManagerView managerView = new ProjectManagerView();
                    ShowNewMenu(managerView);
                }
                else
                {
                    MessageBox.Show("User not found");
                }


            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProjectManagerSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
