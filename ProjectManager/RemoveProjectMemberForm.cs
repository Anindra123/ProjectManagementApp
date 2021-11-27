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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text)==true)
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
            var form = (AdminDashBoard)Tag;
            form.Show();
            this.Close();
        }
    }
}
