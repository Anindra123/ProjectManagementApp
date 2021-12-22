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
    public partial class ForgotPasswordForm : Form
    {
        ProjectMember pUser = new ProjectMember();
        Validations validations = new Validations();

        public ForgotPasswordForm()
        {
            InitializeComponent();

        }
        void SetUserInfo(string name, string mail)
        {
            fullNameLbl.Text = name;
            emailLbl.Text = mail;
        }

        private void submiEmailBtn_Click(object sender, EventArgs e)
        {
            //based on the type of user , takes and email and 
            //updates the label data with the user password

            if (!string.IsNullOrWhiteSpace(enterMailTextBox.Text.Trim())
            && validations.ValidateMail(enterMailTextBox.Text.Trim())
            )
            {
                if (pUser.GetUserByMail(enterMailTextBox.Text.Trim()))
                {

                    DialogResult dr = MessageBox.Show("Found User", "Sucess", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        string fullName = $"{pUser.FirstName} {pUser.LastName}";
                        string email = $"{pUser.Email}";
                        SetUserInfo(fullName, email);
                    }
                }
                else
                {
                    SetUserInfo("none", "none");
                    MessageBox.Show("No account exist for this User / Invalid Mail", "Alert", MessageBoxButtons.OK
                         , MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                SetUserInfo("none", "none");
                MessageBox.Show("Entered Email is Invalid", "Alert", MessageBoxButtons.OK
                       , MessageBoxIcon.Exclamation);
            }



        }



        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void sendMailwithPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (emailLbl.Text == "none" && fullNameLbl.Text == "none")
            {
                validations.ShowAlert("User not set currently");
            }
            else
            {

                string waitMsg = $"Sending password at '{emailLbl.Text}'.Please wait....";
                SendPasswordWaitScreen sendPassword = new SendPasswordWaitScreen(waitMsg);
                sendPassword.Show();
                string msg = $"For, \n" +
                    $"Username : {fullNameLbl.Text}\n" +
                    $"Email : {emailLbl.Text}\n" +
                    $"Your current password is {pUser.password}";
                var result = await Mail.SendMail(msg);

                if (result)
                {

                    sendPassword.CloseForm();
                    DialogResult r = validations.ShowInfo("Mail Send sucessfully");
                    if (r == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    validations.ShowError("Error while sending mail please try again");
                }
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            SetUserInfo("none", "none");
        }
    }
}
