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
    public partial class AdminLogin : Form
    {
        public static string text1;
        public static string text2;
        public AdminLogin()
        {
            InitializeComponent();

        }
        void ShowPreviousMenu()
        {
            var form = (ProjectManagerStartForm)Tag;
            form.Show();
        }
        private void Admin_LogIn_button1_Click(object sender, EventArgs e)
        {
            if (Admin_name_email_TextBox1.Text != "" && Admin_password_masked_textBox1.Text != "")
            {
                text1 = Admin_name_email_TextBox1.Text;
                text2 = Admin_password_masked_textBox1.Text;
            }
            else
            {
                MessageBox.Show("Text fields cannot be empty");
            }
        }

        private void Admin_cancel_button2_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }
    }
}
