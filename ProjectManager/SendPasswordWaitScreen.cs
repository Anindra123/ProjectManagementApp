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
    public partial class SendPasswordWaitScreen : Form
    {
        public SendPasswordWaitScreen()
        {
            InitializeComponent();
        }
        public SendPasswordWaitScreen(string msg)
        {
            InitializeComponent();
            msgLbl.Text = msg;
        }
        public void CloseForm()
        {
            this.Close();
        }
    }
}
