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
        ProjectMember pMember = new ProjectMember();
        ProjectManager pManager = new ProjectManager();
        Validations validations = new Validations();
        string showPasswordFor;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            showPasswordLabel.Text = "none";
        }
        //overloaded constructor
        public ForgotPasswordForm(string showPasswordFor)
        {
            InitializeComponent();
            showPasswordLabel.Text = "none";
            this.showPasswordFor = showPasswordFor;
        }

        private void submiEmailBtn_Click(object sender, EventArgs e)
        {
            //based on the type of user , takes and email and 
            //updates the label data with the user password
            if (showPasswordFor.ToLower() == "projectmember")
            {
                if (!string.IsNullOrWhiteSpace(enterMailTextBox.Text.Trim())
                && pMember.VerifyMail(enterMailTextBox.Text.Trim())
                )
                {
                    if (pMember.GetMemberPass(enterMailTextBox.Text.Trim()))
                    {
                        showPasswordLabel.Text = null;
                        DialogResult dr = MessageBox.Show("Found User", "Sucess", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            for (int i = 0; i < pMember.password.Length; i++)
                            {
                                showPasswordLabel.Text += "*";
                            }
                        }
                    }
                    else
                    {
                        showPasswordLabel.Text = "none";
                        MessageBox.Show("No account exist for this User / Invalid Mail", "Alert", MessageBoxButtons.OK
                             , MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    showPasswordLabel.Text = "none";
                    MessageBox.Show("Entered Email is Invalid", "Alert", MessageBoxButtons.OK
                           , MessageBoxIcon.Exclamation);
                }
            }

            if (showPasswordFor.ToLower() == "projectmanager")
            {
                if (!string.IsNullOrWhiteSpace(enterMailTextBox.Text.Trim())
                && validations.ValidateMail(enterMailTextBox.Text.Trim())
                )
                {
                    if (pManager.GetManagerPass(enterMailTextBox.Text.Trim()))
                    {
                        showPasswordLabel.Text = null;
                        DialogResult dr = MessageBox.Show("Found User", "Sucess", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            for (int i = 0; i < pManager.password.Length; i++)
                            {
                                showPasswordLabel.Text += "*";
                            }
                        }
                    }
                    else
                    {
                        showPasswordLabel.Text = "none";
                        MessageBox.Show("No account exist for this User / Invalid Mail", "Alert", MessageBoxButtons.OK
                             , MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    showPasswordLabel.Text = "none";
                    MessageBox.Show("Entered Email is Invalid", "Alert", MessageBoxButtons.OK
                           , MessageBoxIcon.Exclamation);
                }
            }
        }

        private void showPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //based on the type of user , will show the
            //mask password on the label
            if (showPasswordLabel.Text != "none" && showPasswordFor.ToLower() == "projectmember")
            {
                showPasswordLabel.Text = pMember.password;
            }
            else if (showPasswordLabel.Text != "none" && showPasswordFor.ToLower() == "projectmanager")
            {
                showPasswordLabel.Text = pManager.password;
            }
            else
            {
                MessageBox.Show("No password on the field", "Error", MessageBoxButtons.OK
                       , MessageBoxIcon.Error);
            }
        }

        private void copyToClipboardLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //based on the type of user ,copies the retrived 
            //password to clipboard for user to paste it afterwards
            if (showPasswordLabel.Text != "none" && showPasswordFor.ToLower() == "projectmember")
            {
                Clipboard.SetText(pMember.password);
                MessageBox.Show("Password copied to clipboard", "Copied", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
            }
            else if (showPasswordLabel.Text != "none" && showPasswordFor.ToLower() == "projectmanager")
            {

                Clipboard.SetText(pManager.password);
                MessageBox.Show("Password copied to clipboard", "Copied", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No password on the field", "Error", MessageBoxButtons.OK
                       , MessageBoxIcon.Error);
            }

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
