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
    public partial class AddNewFeature : System.Windows.Forms.Form
    {
        public AddNewFeature()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewFeature_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(titleTextBox.Text))
            {

                MessageBox.Show("Text fields Cannot Be Empty", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (assignToComboBox.Items.Count < 1 && assignSelectionYesRadioBtn.Checked)
            {
                MessageBox.Show("Must select a member", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void assignSelectionNoRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var form = (updatePManagerInfo)Tag;
            form.Show();
            this.Close();
        }

        private void assignSelectionYesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (assignSelectionYesRadioBtn.Checked)
            {
                assignToComboBox.Enabled = true;

               
            }
            else
            {
                assignToComboBox.Enabled = false;
            }
            
        }
    }
}
