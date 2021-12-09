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
        ProjectTask pT = new ProjectTask();
        bool memberOfGroup = false;
        int currentProjID = 0;
        public JoinNewGroup()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectMemberMenu)Tag;
            form.IntializeGroup(pG, proj, pManag);
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
                currentProjID = proj.Project_ID;
                SetGroupInfolabels();
                if (pG.FillMemberList() != null)
                {
                    currentMembersList.DataSource = pG.FillMemberList().Copy();
                    currentMembersList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            else
            {
                memberOfGroup = false;
                pG = new ProjectGroup();
                proj = new Project();
                pManag = new ProjectManager();
                groupNameLabl.Text = "none";
                projNameLabl.Text = "none";
                projMangerLabl.Text = "none";
            }
        }

        private void searchEnterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(groupSerachtxtbox.Text.Trim()))
            {
                if (pG.SearchGroup(groupSerachtxtbox.Text.Trim()))
                {

                    DialogResult result = MessageBox.Show($"Found {pG.PGroup_Name}", "Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK || result == DialogResult.None)
                    {

                        nGrpNameLabl.Text = pG.PGroup_Name;
                        proj.GetProjectTitleForMember(pG.PGroup_ID);
                        pManag.GetProjectManagerInfo(proj.Project_ID);
                        nProjManagLabl.Text = $"{pManag.FirstName} {pManag.LastName}";
                        nProjNameLabl.Text = proj.Project_Title;
                        newMembersList.DataSource = pG.FillMemberList().Copy();
                        newMembersList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    }
                }
                else
                {
                    SetGroupInfolabels();
                    newMembersList.DataSource = null;
                    MessageBox.Show("Group Not found. Try Again", "Alert",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                SetGroupInfolabels();
                newMembersList.DataSource = null;
                MessageBox.Show("Invalid Group Name", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool newGroupFieldValidation()
        {
            if ((string.IsNullOrWhiteSpace(nGrpNameLabl.Text.Trim())
                || nGrpNameLabl.Text == "none")
                && (string.IsNullOrWhiteSpace(nProjManagLabl.Text.Trim())
                || nGrpNameLabl.Text == "none")
                && (string.IsNullOrWhiteSpace(nProjNameLabl.Text.Trim())
                || nGrpNameLabl.Text == "none")
                )
            {
                return false;
            }
            return true;
        }
        private void JoinedGroup()
        {
            DialogResult r = MessageBox.Show("Joined Group Sucessfully", "Sucess",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (r == DialogResult.OK)
            {
                memberOfGroup = true;
                currentProjID = pG.Project_ID;
                SetGroupInfolabels();
                newMembersList.DataSource = pG.FillMemberList().Copy();
                newMembersList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                newMembersList.Update();
                newMembersList.Refresh();
                currentMembersList.DataSource = pG.FillMemberList().Copy();
                currentMembersList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                currentMembersList.Update();
                currentMembersList.Refresh();
            }
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
                        JoinedGroup();
                    }
                }
                else
                {
                    if (!pM.CheckifGroupMember(pM.PMemberID, pG.PGroup_ID))
                    {
                        DialogResult dr = MessageBox.Show("Confirm Group Change ? Your current project progess will be lost", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            int pm_id = pM.PMemberID;
                            if (pT.CheckAssingedToMember(pm_id) != null)
                            {
                                DataTable dt = pT.CheckAssingedToMember(pm_id);
                                foreach (DataRow row in dt.Rows)
                                {
                                    int t_id = (int)row["Task_ID"];
                                    pM.RemoveAllAssignedTask(t_id);
                                }
                            }
                            pM.UpdateMemberGroupInfoTable(pm_id, pG.PGroup_ID);
                            pM.UpdateProjectGroupInfoTable(pm_id, pG.Project_ID);
                            JoinedGroup();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Already Member of the group", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
