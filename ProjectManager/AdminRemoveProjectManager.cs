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
    public partial class AdminRemoveProjectManager : Form
    {
        public AdminRemoveProjectManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ViewProjectManagerInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Field cannot be empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = (AdminDashBoardManager)Tag;
            form.Show();
            this.Close();
        }
    }
}
