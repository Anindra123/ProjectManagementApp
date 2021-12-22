using ProjectManagement.ClassFiles;
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
    public partial class SignInForm : Form
    {
        ProjectMember projectMember = new ProjectMember();
        ProjectManager projectManager = new ProjectManager();
        Validations validations = new Validations();
        public SignInForm()
        {
            InitializeComponent();
        }
        void ShowPreviousForm()
        {
            //Goes to the previous control
            var form = (ProjectManagementStartForm)Tag;
            form.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousForm();
            this.Close();
        }

        private void ProjectMemberSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousForm();
        }

        private void forgotPasswordLinkLabl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            forgotPassword.ShowDialog();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            ShowNewMenu(signUp);
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string mail = emailTextBox.Text.Trim();
            string pass = passTextBox.Text.Trim();
            emailTextBox.Text = null;
            passTextBox.Text = null;
            if (validations.SignInValidation(mail, pass))
            {
                if (User.SignIn(mail, pass))
                {
                    if (User.GetTypeOfUser() == "PMember")
                    {
                        projectMember.FillUserInfo();
                        if (validations.SignInValidation(projectMember))
                        {
                            DialogResult r = validations.ShowInfo("Account Verified.Signed In Sucessfully");
                            if (r == DialogResult.OK)
                            {
                                ProjectMemberMenu memberMenu =
                                    new ProjectMemberMenu();
                                memberMenu.SetMember(projectMember);
                                memberMenu.InitializeDashBoard();
                                ShowNewMenu(memberMenu);
                            }
                        }

                    }

                    else if (User.GetTypeOfUser() == "PManager")
                    {
                        projectManager.FillUserInfo();
                        if (validations.SignInValidation(projectManager))
                        {
                            DialogResult r = validations.ShowInfo("Account Verified.Signed In Sucessfully");
                            if (r == DialogResult.OK)
                            {
                                updatePManagerInfo pManagerInfo = new updatePManagerInfo(projectManager);
                                ShowNewMenu(pManagerInfo);
                            }
                        }
                    }
                }
                else
                {
                    validations.ShowAlert("Invalid Email or password");
                }
            }
        }
    }
}
