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
    public partial class UpdateGroupInfo : Form
    {
        public UpdateGroupInfo()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectManagerView)Tag;
            form.Show();

        }
        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
