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
    public partial class UpdateProjectManager : Form
    {
        ProjectManager pM;
        Validations validations = new Validations();
        public UpdateProjectManager()
        {
            InitializeComponent();
        }
        public UpdateProjectManager(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (updatePManagerInfo)Tag;
            form.IntializeForm();
            form.Show();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProjectManager_Load(object sender, EventArgs e)
        {
            if (pM != null)
            {
                firstNameManagerTxt.Text = pM.FirstName;
                lastNameManagerText.Text = pM.LastName;
                managerEmailTxt.Text = pM.Email;
                managerPasswordTxt.Text = pM.password;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameManagerTxt.Text.Trim();
            string lastName = lastNameManagerText.Text.Trim();
            string email = managerEmailTxt.Text.Trim();
            string password = managerPasswordTxt.Text.Trim();
            if (validations.SignUpAndUpdateValidation<ProjectManager>(true, firstName, lastName, email, password, pM))
            {
                if (pM.UpdateProjectManagerInfo(firstName, lastName, password, email))
                {
                    validations.ShowInfo("Updated Sucessfully");
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            Close();
        }

        private void UpdateProjectManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }
    }
}
