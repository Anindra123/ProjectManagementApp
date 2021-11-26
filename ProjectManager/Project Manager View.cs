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
    public partial class ProjectManagerView : System.Windows.Forms.Form
    {
        public ProjectManagerView()
        {
            InitializeComponent();
        }
        void GotoContinuePage()
        {
            //Goes to project manager continue form
            var form1 = (ProjectManagerSignIn)Tag;
            var form2 = (ContinueAsProjectManagerForm)form1.Tag;
            form1.Close();
            form2.Show();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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
            AddNewFeature adf1 = new AddNewFeature();
            adf1.Show();
            this.Hide();
        }

        private void assignTaskBtn_Click(object sender, EventArgs e)
        {
            AssignTask aT1 = new AssignTask();
            aT1.Show();
            this.Hide();
        }

        private void updateGroupMembersBtn_Click(object sender, EventArgs e)
        {
            UpdateGroupInfo uGI1 = new UpdateGroupInfo();
            uGI1.Show();
            this.Hide();
        }

        private void viewProjectInfoBtn_Click(object sender, EventArgs e)
        {
            ViewProjectInfo vPI1 = new ViewProjectInfo();
            vPI1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProjectInfo uPI1 = new UpdateProjectInfo();
            uPI1.Show();
            this.Hide();
        }
    }
}
