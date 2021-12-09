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
    public partial class SubmitTaskForm : Form
    {
        ProjectTask pT;
        ProjectMember pm;
        ProjectMemberMenu pmMenu;
        byte[] fileData = null;
        Validations validations = new Validations();
        public SubmitTaskForm()
        {
            InitializeComponent();
        }

        public SubmitTaskForm(ProjectTask obj, ProjectMember pmObj,
            ProjectMemberMenu formObj
            )
        {
            InitializeComponent();
            pT = obj;
            pm = pmObj;
            pmMenu = formObj;
        }
        private void SetTaskStatus()
        {
            if (pT.CheckTaskStatus(pT.Task_Completed))
            {
                statusCompletedRadioBtn.Checked = true;
            }
            else
            {
                statusPendingRadioBtn.Checked = true;

            }
        }
        private void DisableFields(bool en)
        {
            browseFilesBtn.Enabled = en;
            taskCmntTxtBox.Enabled = en;
            if (en == false)
            {
                fileNameTextBox.Text = null;
                taskCmntTxtBox.Text = null;
                pT.Task_Completed = 1;
            }

        }
        private void SubmitTaskForm_Load(object sender, EventArgs e)
        {
            taskTitleLabel.Text = pT.Task_Title;
            taskDescLabel.Text = pT.Task_Desc;
            SetTaskStatus();

        }
        private void AttachFile(string fileName)
        {
            FileStream fstream = File.OpenRead(fileName);
            fileData = new byte[fstream.Length];
            fstream.Read(fileData, 0, (int)fstream.Length);
            fstream.Close();
        }
        private void browseFilesBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog() { Filter = "Text Document (.txt)|*.txt", ValidateNames = true })
            {
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    fileNameTextBox.Text = opd.FileName;
                    AttachFile(opd.FileName);
                }
            }
        }

        private void statusPendingRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (statusPendingRadioBtn.Checked == true)
            {
                DisableFields(false);
            }
        }

        private void statusCompletedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (statusCompletedRadioBtn.Checked == true)
            {
                DisableFields(true);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (statusPendingRadioBtn.Checked == true)
            {
                DialogResult dr = MessageBox.Show("No Changes were Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Close();
                }
            }
            if (statusCompletedRadioBtn.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(fileNameTextBox.Text.Trim())
                    && !string.IsNullOrWhiteSpace(taskCmntTxtBox.Text.Trim())
                    )
                {
                    pT.Task_Comment = taskCmntTxtBox.Text.Trim();
                    pT.Task_Completed = 2;
                    if (pm.UpdateTask(pT.Task_ID, fileData))
                    {
                        DialogResult dr = MessageBox.Show("Updated Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                }
                else
                {
                    validations.ShowAlert("Please attach a file and write some comment");
                }
            }
        }

        private void SubmitTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pmMenu.FilterTaskList();
        }
    }
}
