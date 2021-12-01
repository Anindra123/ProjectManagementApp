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
    public partial class updatePManagerInfo : System.Windows.Forms.Form
    {
        ProjectManager pM;
        public updatePManagerInfo()
        {
            InitializeComponent();
        }
        public updatePManagerInfo(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void GotoContinuePage()
        {
            //Goes to project manager continue form
            var form1 = (ProjectManagerSignIn)Tag;
            var form2 = (ContinueAsProjectManagerForm)form1.Tag;
            form1.Close();
            form2.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }

        public void IntializeForm()
        {
            groupAndProjectView.DataSource = null;
            if (pM != null)
            {
                pM.GetProjectManager();
                welcomeFullNameLabel.Text = $"Welcome, {pM.FirstName} {pM.LastName}";
                if (pM.ProjectGroups.Count > 0 && pM.Projects.Count > 0)
                {
                    groupAndProjectView.DataSource = pM.ViewProjectGroupInfo().Copy();
                }
                else
                {
                    groupAndProjectView.DataSource = null;
                }
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void currentProjectsLabel_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoContinuePage();
            this.Close();
        }

        private void addNewFeatureBtn_Click(object sender, EventArgs e)
        {
            AddNewFeature aDF1 = new AddNewFeature();
            ShowNewMenu(aDF1);
        }

        private void updateGroupMembersBtn_Click(object sender, EventArgs e)
        {
            UpdateGroupInfo uGI1 = new UpdateGroupInfo();
            ShowNewMenu(uGI1);
        }

        private void viewProjectInfoBtn_Click(object sender, EventArgs e)
        {
            ViewProjectInfo vPI1 = new ViewProjectInfo();
            ShowNewMenu(vPI1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProjectInfo uPI1 = new UpdateProjectInfo();
            ShowNewMenu(uPI1);
        }

        private void updatePManagerInfoBtn_Click(object sender, EventArgs e)
        {
            UpdateProjectManager uManager = new UpdateProjectManager(pM);
            ShowNewMenu(uManager);
        }

        private void updatePManagerInfo_Load(object sender, EventArgs e)
        {
            IntializeForm();
        }

        private void createNewGroupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
