﻿using System;
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
    public partial class UpdateProjectMemberInfoForm : Form
    {
        public UpdateProjectMemberInfoForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void ShowPreviousMenu()
        {
            var form = (AdminDashBoard)Tag;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }
    }
}
