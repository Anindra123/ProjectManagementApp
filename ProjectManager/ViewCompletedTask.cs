using ProjectManagement.ClassFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class ViewCompletedTask : Form
    {
        ProjectTask task;
        ProjectGroup pGroup = new ProjectGroup();
        Project project = new Project();
        Validations validations = new Validations();
        public ViewCompletedTask()
        {
            InitializeComponent();
        }
        public ViewCompletedTask(ProjectTask task)
        {
            InitializeComponent();
            this.task = task;
        }
        private void InitializeForm()
        {
            groupNameLabel.Text = "none";
            projectTitleLabel.Text = "none";
            taskTitleLabel.Text = "none";
            taskDescLabel.Text = "none";
            taskStatusLabel.Text = "none";
            downloadFiles.Text = "No files attached";
            downloadFiles.Enabled = false;
            commentLabel.Text = "none";
        }
        private void DownloadFiles(string fileName)
        {
            bool dl = false;

            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                //writes byte[] data retrived to a new file 
                //created through the filestream
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    dl = true;
                    bw.Write(task.Task_Attached);
                    bw.Close();
                }
            }
            if (dl == true)
            {
                validations.ShowInfo($"{fileName} downloaded sucessfully");
            }
        }
        private void ViewCompletedTask_Load(object sender, EventArgs e)
        {
            if (task != null)
            {
                pGroup.GetProjectGroupFromTask(task.Task_ID);
                project.GetProjectInfoFromTask(task.Task_ID);
                groupNameLabel.Text = pGroup.PGroup_Name;
                projectTitleLabel.Text = project.Project_Title;
                taskTitleLabel.Text = task.Task_Title;
                taskDescLabel.Text = task.Task_Desc;
                taskStatusLabel.Text = task.GetStatus();
                if (task.GetCompletedTask())
                {
                    downloadFiles.Text = "Download Attached Files";
                    downloadFiles.Enabled = true;
                    commentLabel.Text = task.Task_Comment;
                }
                else
                {
                    downloadFiles.Text = "No files attached";
                    downloadFiles.Enabled = false;
                    commentLabel.Text = "none";
                }

            }
            else
            {
                InitializeForm();
            }
        }

        private void downloadFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open a new window to save a file by giving 
            //file name
            using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Text Document (.txt)|*.txt", ValidateNames = true })
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to download Attached Files ?",
                        "Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string fileName = sf.FileName;
                        DownloadFiles(fileName);
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
