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
using ProjectManagement.ClassFiles;

namespace ProjectManagement
{
    public partial class ProjectManagerSignIn : Form
    {
        ProjectManager pm = new ProjectManager();
        Validations validations = new Validations();
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


        private void projMSignInBtn_Click(object sender, EventArgs e)
        {
            //verifies name and email text and box and checkes
            //whether the email pattern is valid
            if (string.IsNullOrEmpty(projMEmailTextBox.Text) || string.IsNullOrEmpty(projMPasswordTextBox.Text))
            {
                validations.ShowAlert("Fill up all the fields");
            }
            else if (validations.ValidateMail(projMEmailTextBox.Text.Trim()))
            {

                validations.ShowAlert("Invalid Email Format");
            }
            else
            {

                bool ret = pm.SignIn(projMEmailTextBox.Text.Trim(), projMPasswordTextBox.Text.Trim());

                if (ret == true)
                {
                    DialogResult dr = MessageBox.Show("Logged in sucessfully", "Sucess", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        pm.GetProjectGroups();
                        pm.GetProjects();
                        updatePManagerInfo managerView = new updatePManagerInfo(pm);
                        ShowNewMenu(managerView);
                    }
                }
                else
                {
                    validations.ShowAlert("Invalid Email/Password.Try Again");
                }


            }

        }

        private void forgotPasswordLinkLabl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm("projectmanager");
            forgotPassword.ShowDialog();
        }
    }
}
