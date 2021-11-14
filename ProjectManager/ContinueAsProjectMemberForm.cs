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
    public partial class ContinueAsProjectMemberForm : Form
    {
        public ContinueAsProjectMemberForm()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectManagerStartForm)Tag;
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

        private void ContinueAsProjectMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void signUpAsProjectMemberBtn_Click(object sender, EventArgs e)
        {
            MemberSignUpForm memberSignUp = new MemberSignUpForm();
            ShowNewMenu(memberSignUp);
        }

        private void signInAsProjectMemberBtn_Click(object sender, EventArgs e)
        {
            ProjectMemberSignIn memberSignIn =
                new ProjectMemberSignIn();
            ShowNewMenu(memberSignIn);
        }
    }
}
