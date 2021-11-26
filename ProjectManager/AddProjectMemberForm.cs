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
    public partial class AddProjectMemberForm : Form
    {
        public AddProjectMemberForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void ShowPreviousMenu()
        {
            var form = (AdminDashBoard)Tag;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void AddProjectMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
