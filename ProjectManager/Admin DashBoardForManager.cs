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
    public partial class AdminDashBoardManager : Form
    {
        public AdminDashBoardManager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewProjectManagerInfo vPMi1 = new ViewProjectManagerInfo();
            vPMi1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = (AdminOptions)Tag;
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminRemoveProjectManager aRPM1 = new AdminRemoveProjectManager();
            aRPM1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpadateProjectManager uPM1 = new UpadateProjectManager();
            uPM1.Show();
            this.Hide();
        }
    }
}
