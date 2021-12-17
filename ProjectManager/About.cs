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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Anindra Das Bivas", "20-41848-1", "CRUD Operations");
            dataGridView1.Rows.Add("Sumi Akther", "20-43154-1", "All Form Design");
            dataGridView1.Rows.Add("Shahed Chowdhury Omi", "18-38760-3", "All Form Validations");
            dataGridView1.Rows.Add("Muntezar Rabbani", "20-44064-2", "All Form Navigations");
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.ClearSelection();
        }
    }
}
