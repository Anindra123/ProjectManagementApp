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
    public delegate void SetProjectAndGroup(int id);
    public partial class ProjectMemberMenu : Form
    {
        static ProjectMember projectMember;
        Project project = new Project();
        ProjectGroup projGroup = new ProjectGroup();
        ProjectManager projectManager = new ProjectManager();


        public static void SetMember(ProjectMember pm)
        {
            projectMember = pm;
        }
        private void Setlabels(string groupName, string firstName, string LastName,
            string title)
        {
            projectGroupNameLabel.Text = $"{groupName}";
            projectLeaderNameLabel.Text = $"{firstName} {LastName}";
            projectTitleLabel.Text = $"{title}";
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
        private void AssignObjectsValues()
        {
            SetProjectAndGroup setProjectAndGroup = project.GetProjectInfo;
            setProjectAndGroup += projGroup.GetPGroupInfo;
            setProjectAndGroup(projectMember.PMemberID);
            projectManager.GetProjectManagerInfo(project.Project_ID);
        }
        private void ProjectMemberMenu_Load(object sender, EventArgs e)
        {
            displayMemberTitleLabel.Text = $"Hello, {projectMember.FirstName} {projectMember.LastName}";
            if (projectMember.CheckifGroupMember(projectMember.PMemberID))
            {
                AssignObjectsValues();
                Setlabels(projGroup.PGroup_Name, projectManager.FirstName, projectManager.LastName, project.Project_Title);
            }
            else
            {
                Setlabels("none", "none", "", "none");
            }
        }
    }
}
