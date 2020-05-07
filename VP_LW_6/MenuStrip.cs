using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using ArrIntSpace;

namespace VP_LW_6
{
    public partial class MenuStrip : Form
    {
       // private DataGridView dataGridView1;
        private void DataGridViewInitialize() // Making our DataGrid
        {
            dataGridView2.ColumnCount = 2; // Column Count
            dataGridView2.RowCount = 2;
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            dataGridView2.Columns[0].Name = "Chart 1";
            dataGridView2.Columns[1].Name = "Chart 2";
            dataGridView2.Columns[2].Name = "Chart 3";
            // Defining rows
            string[] row1 = new string[] { "0" };
            string[] row2 = new string[] { "0" };
            string[] row3 = new string[] { "0" };
            object[] rows = new object[] { row1, row2, row3 }; // Storing all rows inside of an array
            //Adding rows
            foreach (string[] rowArray in rows)
            {
                dataGridView2.Rows.Add(rowArray);
            }
        }


        public MenuStrip()
        {
            InitializeComponent();
            string Arr_file;
            
        }
        
        private void MenuStrip_Load(object sender, EventArgs e)
        {

        }

    //Раздел "Меню"
       
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выгрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    //Раздел "Работа
        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void изменениеЭлементовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поСтолбцуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void поНомеруСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int n = dataGridView2.RowCount;
            //int m = dataGridView2.ColumnCount;
            int n = 2;
            int m = 2;
            Collection<ArrInt> ArrInt1 = new Collection<ArrInt>();
            ArrInt Arr = new ArrInt(n, m);

            Arr.InputArray();
            ArrInt1.Add(Arr);
            int i = 0;
 
            if (dataGridView2.ColumnCount < ArrInt1.Count)
            {
                dataGridView2.ColumnCount = ArrInt1.Count;
            }
            foreach (ArrInt arr in ArrInt1)
            {
               dataGridView2.Rows[i].Cells[0].Value = arr.Sum_Column(1);
               i++;
            }
        }
    }
}
