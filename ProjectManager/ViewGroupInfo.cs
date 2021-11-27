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
    public partial class ViewGroupInfo : Form
    {
        ProjectManager pManager;
        ProjectGroup pGroup;
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectMemberMenu)Tag;
            form.Show();
        }
        public ViewGroupInfo()
        {
            InitializeComponent();
        }
        public ViewGroupInfo(ProjectManager pm, ProjectGroup pg)
        {
            InitializeComponent();
            pManager = pm;
            pGroup = pg;


        }
        private void SetGroupInfolabels(string gName, string firstName, string LastName)
        {
            groupNameLabel.Text = $"{gName}";
            groupManagerLabel.Text = $"{firstName} {LastName}";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewGroupInfo_Load(object sender, EventArgs e)
        {
            if (pManager != null && pGroup != null)
            {
                SetGroupInfolabels(pGroup.PGroup_Name, pManager.FirstName, pManager.LastName);
                if (pGroup.FillMemberList() != null)
                {
                    groupMemberGridView.DataSource = pGroup.FillMemberList();
                    groupMemberGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                }
            }
            else
            {
                SetGroupInfolabels("none", "none", "");
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void ViewGroupInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();

        }
    }
}
