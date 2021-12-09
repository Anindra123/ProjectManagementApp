using ProjectManagement.ClassFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class MemberSignUpForm : Form
    {
        //defined a regular expression for mail validation
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        ProjectMember projectMember = new ProjectMember();
        ProjectGroup projectGroup = new ProjectGroup();
        ProjectManager projectManager = new ProjectManager();
        Project project = new Project();
        public MemberSignUpForm()
        {
            InitializeComponent();


        }
        void BackToHomeMenu()
        {
            //Close the current form and the form before it
            //And show homepage
            var form1 = (ContinueAsProjectMemberForm)Tag;
            var form2 = (ProjectManagementStartForm)form1.Tag;
            form1.Close();
            form2.Show();

        }


        void ResetSignUpFeilds()
        {
            projectMemberEmailTextBox.Text = null;
            projMemFirstNameTextBox.Text = null;
            projMLastNameTextBox.Text = null;
            projMemberPasswordTextBox.Text = null;


        }

        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ContinueAsProjectMemberForm)Tag;
            form.Show();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void MemberSignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void goBackHomePageBtn_Click(object sender, EventArgs e)
        {
            BackToHomeMenu();
            this.Close();
        }

        bool validateMatchingMailAndPass()
        {
            if (!projectMember.CheckDuplicateMailAndPass(projectMemberEmailTextBox.Text.Trim(),
                projMemberPasswordTextBox.Text.Trim()))
            {
                return true;
            }
            return false;
        }
        private void projMemberSignUpBtn_Click(object sender, EventArgs e)
        {
            //Check the main fields
            if (!string.IsNullOrWhiteSpace(projMemFirstNameTextBox.Text.Trim())
                && !string.IsNullOrWhiteSpace(projMLastNameTextBox.Text.Trim())
                && !string.IsNullOrWhiteSpace(projMemberPasswordTextBox.Text.Trim())
                && !string.IsNullOrWhiteSpace(projectMemberEmailTextBox.Text.Trim())
                )
            {
                //Email validation
                if (Regex.IsMatch(projectMemberEmailTextBox.Text.Trim(), pattern))
                {
                    if (projMemberPasswordTextBox.Text.Trim().Length <= 8)
                    {
                        //Validate the group info feild

                        if (validateMatchingMailAndPass())
                        {
                            bool val = projectMember.SignUPProjectMember(
                            projMemFirstNameTextBox.Text.Trim(),
                            projMLastNameTextBox.Text.Trim(),
                            projectMemberEmailTextBox.Text.Trim(),
                            projMemberPasswordTextBox.Text.Trim()
                            );



                            if (val == true)
                            {

                                DialogResult result = MessageBox.Show("Sign Up Sucessful", "Sucess",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (result == DialogResult.OK)
                                {
                                    ResetSignUpFeilds();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("An Entry with same name/email or password already exist. Try something different", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Password can be 8 characters long", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email Is Invalid", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Text fields Cannot Be Empty", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void groupConfirmBtn_Click(object sender, EventArgs e)
        {

        }

        private void projMemFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
