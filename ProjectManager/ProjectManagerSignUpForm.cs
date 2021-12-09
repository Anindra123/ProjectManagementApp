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

        private void proMCreateNewProj_Click(object sender, EventArgs e)
        {
            //Give control to the nextform


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

        //[TODO]
        // implement the radio button functionalities
        // validate text fields along with email
        // validate the group form 
        // save the sign up info in a database or textbox
        private void proMSignUp_Click(object sender, EventArgs e)
        {
            string firstName = proMFirstNameTextBox.Text.Trim();
            string lastName = proMLastNameTextBox.Text.Trim();
            string email = proMEmailTextBox.Text.Trim();
            string password = proMPasswordTextBox.Text.Trim();

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password)
                )
            {

                MessageBox.Show("Text Fields Cannot be empty", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid Email", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pM.CheckDuplicateMailAndPass(email, password))
            {
                MessageBox.Show("An Entry with same name/email/password already exist. Try something different", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetSignUpFeilds();
            }
            else if (password.Length > 8)
            {

                validations.ShowAlert("Password can be maximum 8 characters long");
            }
            else
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void proMFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proMYesMembersRadio_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void proMSearchMemBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProjectManagerSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
