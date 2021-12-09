using ProjectManagement.ClassFiles;
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
    public partial class BackLogTaskView : Form
    {
        BackLog backLog;
        public BackLogTaskView()
        {
            InitializeComponent();
        }
        public BackLogTaskView(BackLog backLog)
        {
            InitializeComponent();
            this.backLog = backLog;
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (updatePManagerInfo)Tag;
            form.IntializeForm();
            form.Show();
        }

        private void BackLogTaskView_Load(object sender, EventArgs e)
        {
            backLogHistoryGridView.DataSource = null;
            DataTable dt = backLog.GetBackLogData();
            if (dt != null)
            {
                backLogHistoryGridView.DataSource = dt.Copy();
                backLogHistoryGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                backLogHistoryGridView.ClearSelection();
            }
        }

        private void goBackbtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            Close();
        }

        private void BackLogTaskView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }
    }
}
