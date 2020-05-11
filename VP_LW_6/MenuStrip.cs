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
       static int n = 2;
       static int m = 2;
        List<ArrInt> ArrInt1 = new List<ArrInt>();
        ArrInt Arr = new ArrInt(n, m);


        // private DataGridView dataGridView1;
        private void DataGridViewInitialize() // Making our DataGrid
        {
            //dataGridView2.ColumnCount = 2; // Column Count
            //dataGridView2.RowCount = 2;
            //DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            //columnStyle.BackColor = Color.Azure;
            //columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            //dataGridView2.Columns[0].Name = "Элемент 1";
            //dataGridView2.Columns[1].Name = "Элемент 2";
            //dataGridView2.Columns[2].Name = "Элемент 3";
            //// Defining rows
            //string[] row1 = new string[] { "0" };
            //string[] row2 = new string[] { "0" };
            //string[] row3 = new string[] { "0" };
            //object[] rows = new object[] { row1, row2, row3 }; // Storing all rows inside of an array
            ////Adding rows
            //foreach (string[] rowArray in rows)
            //{
            //    dataGridView2.Rows.Add(rowArray);
            //}
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            int MaxRows = 3;
            dataGridView2.Columns.Add("A1", "Столбец 1");
            dataGridView2.Columns.Add("A2", "Столбец 2");
            dataGridView2.AllowUserToAddRows = false;
            //if (dataGridView2.Rows.Count < MaxRows)
            //{
            //    dataGridView2.AllowUserToAddRows = true;
            //    dataGridView2.Rows.Add();
            //}
            //else
            //{
            //    dataGridView2.AllowUserToAddRows = false;
            //}

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
            MessageBox.Show("Добро пожаловaть в программу!","О программе" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowBox.Text = "Массив 1:\n" + Arr.ToString();
            ArrInt arr = new ArrInt(n, m);
            int i = 0;
            ShowBox.Clear();
            foreach (ArrInt ar in ArrInt1)
            {
                ShowBox.Text += "Массив:" + i + ar.ToString()+"\n";
                i++;          
            }
                //ShowBox.Text = ArrInt1.ToString();
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
            DataGridViewInitialize();

            int i = 0;
             if (dataGridView2.ColumnCount < ArrInt1.Count)
            {
                dataGridView2.ColumnCount = ArrInt1.Count;
            }
            foreach (ArrInt arr in ArrInt1)
            {
                int selrow = dataGridView2.SelectedCells[i].RowIndex;
                // dataGridView2.Rows[i].Cells[0].Value = arr.Sum_Column(1);
                int Sum = arr.Sum_Column(selrow);
                MessageBox.Show(Convert.ToString(Sum));
                i++;
            }
        }

        private void ввестиСКлавиатурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView2.ColumnCount = 2; // Column Count
            //dataGridView2.RowCount = 2;
            DataGridViewInitialize();
            dataGridView2.AllowUserToAddRows = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ArrInt Arr = new ArrInt(n, m);
            for (int i = 0; i < dataGridView2.RowCount-1; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    Arr.InputArray(Convert.ToInt16(this.dataGridView2.Rows[j].Cells[i].Value),i,j);
                }
            }
            this.ArrInt1.Add(Arr);
            ArrInt1.Count();                
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.AllowUserToAddRows = false;
        }


    }
}
