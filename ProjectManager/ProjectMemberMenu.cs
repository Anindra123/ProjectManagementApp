using ProjectManagement.ClassFiles;
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
    public partial class ProjectMemberMenu : Form
    {
        static ProjectMember projectMember;
        public static void SetMember(ProjectMember pm)
        {
            projectMember = pm;
        }

        public ProjectMemberMenu()
        {
            InitializeComponent();
        }
        void GotoContinuePage()
        {
            //Goes to project manager continue form
            var form1 = (ProjectMemberSignIn)Tag;
            var form2 = (ContinueAsProjectMemberForm)form1.Tag;
            form1.Close();
            form2.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoContinuePage();
        }

        private void ProjectMemberMenu_Load(object sender, EventArgs e)
        {
            displayMemberTitleLabel.Text = $"Hello {projectMember.FirstName} {projectMember.LastName}";
        }
    }
}
