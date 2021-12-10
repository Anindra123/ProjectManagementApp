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
using ProjectManagement.ClassFiles;

namespace ProjectManagement
{
    public partial class ProjectManagerSignUpForm : Form
    {

        ProjectManager pM = new ProjectManager();
        Validations validations = new Validations();
        public ProjectManagerSignUpForm()
        {
            InitializeComponent();
        }
        void ShowPreviousForm()
        {
            //Goes to the previous control
            var form = (ContinueAsProjectManagerForm)Tag;
            form.Show();
        }
        void BackToHomeMenu()
        {
            //Close the current form and the form before it
            //And show homepage
            var form1 = (ContinueAsProjectManagerForm)Tag;
            var form2 = (ProjectManagementStartForm)form1.Tag;
            form1.Close();
            form2.Show();

        }
        void ResetSignUpFeilds()
        {
            //empty text feild after user signed up
            proMFirstNameTextBox.Text = "";
            proMLastNameTextBox.Text = "";
            proMEmailTextBox.Text = "";
            proMPasswordTextBox.Text = "";
        }
        private void proMCancel_Click(object sender, EventArgs e)
        {
            ShowPreviousForm();
            this.Close();
        }

        private void ProjectManagerSignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousForm();
        }

        private void goBackHomePageBtn_Click(object sender, EventArgs e)
        {
            BackToHomeMenu();
            this.Close();
        }


        private void proMSignUp_Click(object sender, EventArgs e)
        {
            string firstName = proMFirstNameTextBox.Text.Trim();
            string lastName = proMLastNameTextBox.Text.Trim();
            string email = proMEmailTextBox.Text.Trim();
            string password = proMPasswordTextBox.Text.Trim();

            //calling the generic method from validations
            if (validations.SignUpAndUpdateValidation<ProjectManager>(false,
                firstName, lastName, email, password, pM))
            {
                bool ret = pM.SignUp(firstName, lastName, email, password);

                if (ret == true)
                {
                    MessageBox.Show("User Successfully Signed Up", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetSignUpFeilds();
                }
                else
                {
                    MessageBox.Show("Error in Sign Up", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
