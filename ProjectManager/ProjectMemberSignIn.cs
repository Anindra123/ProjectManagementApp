using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class ProjectMemberSignIn : Form
    {
        public ProjectMemberSignIn()
        {
            InitializeComponent();
        }
        void ShowPreviousForm()
        {
            //Goes to the previous control
            var form = (ContinueAsProjectMemberForm)Tag;
            form.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousForm();
            this.Close();
        }

        private void ProjectMemberSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousForm();
        }

        private void signInAsProjectMemberBtn_Click(object sender, EventArgs e)
        {
            //Sign in form text fields empty validation
            if (!String.IsNullOrWhiteSpace(projMemberNameOREmailTextBox.Text)
                && !String.IsNullOrWhiteSpace(projMemberPasswordTextBox.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Logged in sucessfully",
                    "Sucess",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    //[TO DO] - validate the member name/email and password
                    ProjectMemberMenu memberMenu =
                        new ProjectMemberMenu();
                    ShowNewMenu(memberMenu);
                }
            }
            else
            {
                MessageBox.Show(
                    "Text Fields Cannot Be Empty",
                    "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

            }
        }
    }
}
