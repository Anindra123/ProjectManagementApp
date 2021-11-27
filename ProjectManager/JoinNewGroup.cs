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
    public partial class JoinNewGroup : Form
    {
        ProjectMember pM;
        Project proj;
        ProjectGroup pG;
        ProjectManager pManag;
        bool memberOfGroup = false;
        public JoinNewGroup()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectMemberMenu)Tag;
            form.InitializeDashBoard();
            form.Show();
        }
        public JoinNewGroup(ProjectMember pM, Project proj, ProjectGroup pG,
            ProjectManager pManag)
        {
            InitializeComponent();
            this.pM = pM;
            this.proj = proj;
            this.pG = pG;
            this.pManag = pManag;
        }
        private void SetGroupInfolabels()
        {
            groupNameLabl.Text = pG.PGroup_Name;
            projMangerLabl.Text = $"{pManag.FirstName} {pManag.LastName}";
            projNameLabl.Text = proj.Project_Title;
            nGrpNameLabl.Text = "none";
            nProjManagLabl.Text = "none";
            nProjNameLabl.Text = "none";
        }
        private void JoinNewGroup_Load(object sender, EventArgs e)
        {
            if (proj != null && pG != null && pManag != null)
            {
                memberOfGroup = true;
                SetGroupInfolabels();
                if (pG.FillMemberList() != null)
                {
                    currentMembersList.DataSource = pG.FillMemberList();
                    currentMembersList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            else
            {
                pG = new ProjectGroup();
                proj = new Project();
                pManag = new ProjectManager();
                SetGroupInfolabels();
            }
        }

        private void groupSerachtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchEnterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(groupSerachtxtbox.Text.Trim()))
            {
                if (pG.SearchGroup(groupSerachtxtbox.Text.Trim()))
                {

                    DialogResult result = MessageBox.Show($"Found {pG.PGroup_Name}", "Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        nGrpNameLabl.Text = pG.PGroup_Name;
                        proj.GetProjectTitleForMember(pG.PGroup_ID);
                        pManag.GetProjectManagerInfo(proj.Project_ID);
                        nProjManagLabl.Text = $"{pManag.FirstName} {pManag.LastName}";
                        nProjNameLabl.Text = proj.Project_Title;
                    }
                }
                else
                {
                    MessageBox.Show("Group Not found. Try Again", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Group Name", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool newGroupFieldValidation()
        {
            if (string.IsNullOrWhiteSpace(nGrpNameLabl.Text.Trim())
                && string.IsNullOrWhiteSpace(nProjManagLabl.Text.Trim())
                && string.IsNullOrWhiteSpace(nProjNameLabl.Text.Trim()))
            {
                return false;
            }
            return true;
        }
        private void joinGroupBtn_Click(object sender, EventArgs e)
        {
            if (newGroupFieldValidation())
            {
                if (!memberOfGroup)
                {
                    DialogResult dr = MessageBox.Show("Confirm Join ?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        pM.SaveProjectInfo(proj.Project_ID);
                        pM.SaveGroupInfo(pG.PGroup_ID);
                        DialogResult r = MessageBox.Show("Joined Group Sucessfully", "Sucess",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (r == DialogResult.OK)
                        {
                            memberOfGroup = false;
                            SetGroupInfolabels();
                            newMembersList.Update();
                            newMembersList.Refresh();
                            currentMembersList.Update();
                            currentMembersList.Refresh();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No new group was Assigned", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void JoinNewGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }
    }
}
