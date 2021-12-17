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
using System.Data.SqlClient;
using ProjectManagement.ClassFiles;

namespace ProjectManagement
{
    public partial class AdminLoginForm : Form
    {
        Admin admin = new Admin();
        Validations validations = new Validations();

        public AdminLoginForm()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectManagementStartForm)Tag;
            form.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void AdminLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uName = adminUserName.Text.Trim();
            string pass = adminPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(uName) ||
                string.IsNullOrWhiteSpace(pass))
            {
                validations.ShowAlert("Username and password cannot be empty");
            }
            else
            {
                admin.FirstName = uName;
                admin.password = pass;
                if (admin.SignIn())
                {
                    DialogResult r = validations.ShowInfo("Logged in sucessfully");
                    if (r == DialogResult.OK)
                    {
                        AdminDashboardForm adminDashboard = new AdminDashboardForm(admin);
                        ShowNewMenu(adminDashboard);

                    }
                }
                else
                {
                    validations.ShowAlert("Username or password invalid");
                }
            }
        }
    }
}
