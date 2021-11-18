﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    
    public partial class ProjectManagementStartForm : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        public ProjectManagementStartForm()
        {
            InitializeComponent();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        private void continueAsAdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            ShowNewMenu(adminLogin);
        }

        private void continueAsProjectMemberBtn_Click(object sender, EventArgs e)
        {
            ContinueAsProjectMemberForm memberForm =
                new ContinueAsProjectMemberForm();
            ShowNewMenu(memberForm);
        }

        private void continueAsProjectManagerBtn_Click(object sender, EventArgs e)
        {
            ContinueAsProjectManagerForm managerForm =
                new ContinueAsProjectManagerForm();
            ShowNewMenu(managerForm);
        }

        private void ProjectManagementStartForm_Load(object sender, EventArgs e)
        {

        }
    }
}