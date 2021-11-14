using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class ProjectManagerSignIn : Form
    {
        public ProjectManagerSignIn()
        {
            InitializeComponent();
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ContinueAsProjectManagerForm)Tag;
            form.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void ProjectManagerSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        //[TO DO] - implement text feild validation
        // validate manager password and name/mail
        private void projMSignInBtn_Click(object sender, EventArgs e)
        {
            ProjectManagerView managerView = new
                ProjectManagerView();
            ShowNewMenu(managerView);
        }
    }
}
