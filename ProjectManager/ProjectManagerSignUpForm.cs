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
            string firstName = proMFirstNameTextBox.Text;
            string lastName = proMLastNameTextBox.Text;
            string email = proMEmailTextBox.Text;
            string password = proMPasswordTextBox.Text;
            
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) 
                )
            {

                MessageBox.Show("Text Fields Cannot be empty", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid Email", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aninda will query
                ProjectManager pM = new ProjectManager();
                bool ret = pM.SignUp(firstName, lastName, email, password);

                
       
                if(ret == true)
                {
                    MessageBox.Show("User Successfully Signed Up", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    proMFirstNameTextBox.Text = "";
                    proMLastNameTextBox.Text = "";
                    proMEmailTextBox.Text = "";
                    proMPasswordTextBox.Text = "";
                   
                }
                else
                {
                    MessageBox.Show("Use a different email, this email already exists", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
