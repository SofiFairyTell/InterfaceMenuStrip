using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VP_LW_6
{
    public partial class FindForm : Form
    {
        private void DataGridViewInitialize() // Making our DataGrid
        {
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            int MaxRows = 3;
            FindGrid.Columns.Add("A1", "Столбец 1");
            FindGrid.Columns.Add("A2", "Столбец 2");
            FindGrid.Rows.Add(2);
            FindGrid.AllowUserToAddRows = false;
        }
        public FindForm()
        {
            InitializeComponent();
            DataGridViewInitialize();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }
    }
}
