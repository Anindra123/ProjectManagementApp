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
    public partial class UpdateProjectInfo : Form
    {
        public UpdateProjectInfo()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            var form = (ProjectManagerView)Tag;
            form.Show();
            this.Close();
        }
    }
}
