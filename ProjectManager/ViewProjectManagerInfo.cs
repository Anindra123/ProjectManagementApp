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
    public partial class ViewProjectManagerInfo : Form
    {
        public ViewProjectManagerInfo()
        {
            InitializeComponent();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                comboBox1.Focus();
                errorProvider1.SetError(this.comboBox1, "Field cannot be empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
