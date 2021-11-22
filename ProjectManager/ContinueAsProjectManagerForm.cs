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
    public partial class ContinueAsProjectManagerForm : Form
    {
        public ContinueAsProjectManagerForm()
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

        private void goBackbtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void ContinueAsProjectManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void signUpAsProjectManagerBtn_Click(object sender, EventArgs e)
        {
            ProjectManagerSignUpForm managerSignUpForm =
                new ProjectManagerSignUpForm();
            ShowNewMenu(managerSignUpForm);
        }

        private void signInAsProjectManagerBtn_Click(object sender, EventArgs e)
        {
            ProjectManagerSignIn managerSignIn = new ProjectManagerSignIn();
            ShowNewMenu(managerSignIn);
        }
    }
}
