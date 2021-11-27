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
    public partial class ProjectMemberSignIn : Form
    {
        ProjectMember projectMember = new ProjectMember();
        public ProjectMemberSignIn()
        {
            InitializeComponent();
        }
        void ShowPreviousForm()
        {
            //Goes to the previous control
            var form = (ContinueAsProjectMemberForm)Tag;
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

        private void signInAsProjectMemberBtn_Click(object sender, EventArgs e)
        {
            //Sign in form text fields empty validation
            if (!String.IsNullOrWhiteSpace(projMemberNameOREmailTextBox.Text)
                && !String.IsNullOrWhiteSpace(projMemberPasswordTextBox.Text))
            {
                if (projectMember.SignInProjectMember(projMemberNameOREmailTextBox.Text.Trim(),
                    projMemberPasswordTextBox.Text.Trim()
                    ))
                {
                    DialogResult result = MessageBox.Show(
                    "Logged in sucessfully",
                    "Sucess",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    if (result == DialogResult.OK)
                    {

                        ProjectMemberMenu memberMenu =
                            new ProjectMemberMenu();
                        memberMenu.SetMember(projectMember);
                        ShowNewMenu(memberMenu);
                    }
                }
                else
                {
                    MessageBox.Show(
                   "Invalid Email or password. Please try again.",
                   "Alert",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
                }
            }

            else
            {
                MessageBox.Show(
                    "Text Fields Cannot Be Empty",
                    "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

            }
        }

        private void ProjectMemberSignIn_Load(object sender, EventArgs e)
        {

        }

        private void forgotPasswordLinkLabl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            forgotPassword.Show();
        }
    }
}
