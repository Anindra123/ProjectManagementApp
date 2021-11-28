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
    public partial class ViewMemberProjectInfo : Form
    {
        Project project;
        ProjectMember pM;
        ProjectManager pManager;
        ProjectTask pTask = new ProjectTask();
        public ViewMemberProjectInfo()
        {
            InitializeComponent();
        }
        public ViewMemberProjectInfo(Project project, ProjectMember pM
            , ProjectManager pManager)
        {
            InitializeComponent();
            this.project = project;
            this.pM = pM;
            this.pManager = pManager;
        }
        void ShowPreviousForm()
        {
            //Goes to the previous control
            var form = (ProjectMemberMenu)Tag;
            form.Show();
        }
        private void goBackBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousForm();
            this.Close();
        }
        private void setProjectInfoLabel(string pTitle,
            string pDesc, string pStart, string pEnd, string pManager
            )
        {
            projectTitleLbl.Text = pTitle;
            projectDescLbl.Text = pDesc;
            projManagerLbl.Text = pManager;
            projStartDate.Text = pStart;
            projEndDate.Text = pEnd;


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewMemberProjectInfo_Load(object sender, EventArgs e)
        {
            if (project != null && pManager != null)
            {
                string start = project.Project_StartDate.ToShortDateString();
                string end = project.Project_EndDate.ToShortDateString();
                setProjectInfoLabel(
                    pTitle: project.Project_Title,
                    pDesc: project.Project_Desc,
                    pManager: $"{pManager.FirstName} {pManager.LastName}",
                    pStart: start,
                    pEnd: end
                    );
                if (pTask.FillAssignedTaskList(pM.PMemberID) != null)
                {
                    projectTaskGridView.DataSource = pTask.FillAssignedTaskList(pM.PMemberID).Copy();
                    projectTaskGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            else
            {
                setProjectInfoLabel("none", "none", "none", "none", "none");
                projectTaskGridView.DataSource = null;
            }
        }
    }
}
