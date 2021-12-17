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
    public partial class SignUpForm : Form
    {

        ProjectMember projectMember = new ProjectMember();
        ProjectGroup projectGroup = new ProjectGroup();
        ProjectManager projectManager = new ProjectManager();
        Project project = new Project();
        Validations validations = new Validations();
        bool lastNameExist = false;
        int typeOfUser = 1;
        public SignUpForm()
        {
            InitializeComponent();
            lastNameNoRadioBtn.Checked = true;
            projMemSignUpRadioBtn.Checked = true;
            projMLastNameTextBox.Enabled = false;
            lastNameExist = false;
            typeOfUser = 1;

        }
        //void BackToHomeMenu()
        //{
        //    //Close the current form and the form before it
        //    //And show homepage
        //    var form1 = (ContinueAsProjectMemberForm)Tag;
        //    var form2 = (ProjectManagementStartForm)form1.Tag;
        //    form1.Close();
        //    form2.Show();

        //}


        void ResetSignUpFeilds()
        {
            //after signin up will clear the text feilds
            projectMemberEmailTextBox.Text = null;
            projMemFirstNameTextBox.Text = null;
            projMLastNameTextBox.Text = null;
            projMemberPasswordTextBox.Text = null;
            lastNameNoRadioBtn.Checked = true;
            projMemSignUpRadioBtn.Checked = true;
            projMLastNameTextBox.Enabled = false;
            lastNameExist = false;
            typeOfUser = 1;

        }

        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (SignInForm)Tag;
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
            //BackToHomeMenu();
            //this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string fName = projMemFirstNameTextBox.Text.Trim();
            string lName = projMLastNameTextBox.Text.Trim();
            string email = projectMemberEmailTextBox.Text.Trim();
            string password = projMemberPasswordTextBox.Text.Trim();
            //generic method for validating sign up information 
            //from Validation class called
            if (validations.SignUpAndUpdateValidation(false,
                fName, lName, email, password, lastNameExist))
            {

                if (lastNameExist == true)
                {
                    bool val = User.SignUp(fName, lName, email, password, typeOfUser);

                    if (val == true)
                    {

                        DialogResult result = validations.ShowInfo("Sign Up Sucessful.Account verification request has been sent.");
                        if (result == DialogResult.OK)
                        {
                            ResetSignUpFeilds();
                        }
                    }
                    else
                    {
                        validations.ShowAlert("Problem in signing up.Please try again later");
                    }
                }
                else if (lastNameExist == false)
                {
                    bool val = User.SignUp(fName, email, password, typeOfUser);

                    if (val == true)
                    {

                        DialogResult result = validations.ShowInfo("Sign Up Sucessful.Account verification request has been sent.");
                        if (result == DialogResult.OK)
                        {
                            ResetSignUpFeilds();
                        }
                    }
                    else
                    {
                        validations.ShowAlert("Proble in signing up.Please try again later");
                    }
                }
            }
        }

        private void lastNameYesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (lastNameYesRadioBtn.Checked == true)
            {
                lastNameExist = true;
                projMLastNameTextBox.Enabled = true;
            }
        }

        private void lastNameNoRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (lastNameNoRadioBtn.Checked == true)
            {
                lastNameExist = false;
                projMLastNameTextBox.Enabled = false;
            }
        }

        private void projMemSignUpRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (projMemSignUpRadioBtn.Checked == true)
            {
                typeOfUser = 1;
            }
        }

        private void projManSignUpRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (projManSignUpRadioBtn.Checked == true)
            {
                typeOfUser = 2;
            }
        }
    }
}
