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
    public partial class RemoveProjectMemberForm : Form
    {
        public RemoveProjectMemberForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void ShowPreviousMenu()
        {
            var form = (AdminDashBoard)Tag;
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
