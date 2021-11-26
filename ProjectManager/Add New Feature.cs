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

        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectManagerView)Tag;
            form.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewFeature_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }
    }
}
