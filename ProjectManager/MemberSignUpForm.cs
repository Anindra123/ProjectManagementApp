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

        ProjectMember projectMember = new ProjectMember();
        ProjectGroup projectGroup = new ProjectGroup();
        ProjectManager projectManager = new ProjectManager();
        Project project = new Project();
        Validations validations = new Validations();
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
            //after signin up will clear the text feilds
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


        private void projMemberSignUpBtn_Click(object sender, EventArgs e)
        {
            string fName = projMemFirstNameTextBox.Text.Trim();
            string lName = projMLastNameTextBox.Text.Trim();
            string email = projectMemberEmailTextBox.Text.Trim();
            string password = projMemberPasswordTextBox.Text.Trim();
            //generic method for validating sign up information 
            //from Validation class called
            if (validations.SignUpAndUpdateValidation<ProjectMember>(false,
                fName, lName, email, password, projectMember))
            {

                bool val = projectMember.SignUPProjectMember(
                              fName, lName, email, password);

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

        }




    }
}
