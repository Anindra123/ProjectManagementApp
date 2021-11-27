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
        ProjectMember pM = new ProjectMember();
        public ForgotPasswordForm()
        {
            InitializeComponent();
            showPasswordLabel.Text = "none";
        }

        private void submiEmailBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(enterMailTextBox.Text.Trim())
                && pM.VerifyMail(enterMailTextBox.Text.Trim())
                )
            {
                if (pM.GetMemberPass(enterMailTextBox.Text.Trim()))
                {
                    showPasswordLabel.Text = null;
                    DialogResult dr = MessageBox.Show("Found User", "Sucess", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        for (int i = 0; i < pM.password.Length; i++)
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

        private void showPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (showPasswordLabel.Text != "none")
            {
                showPasswordLabel.Text = pM.password;
            }
            else
            {
                MessageBox.Show("No password on the field", "Error", MessageBoxButtons.OK
                       , MessageBoxIcon.Error);
            }
        }

        private void copyToClipboardLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (showPasswordLabel.Text != "none")
            {
                Clipboard.SetText(pM.password);
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
