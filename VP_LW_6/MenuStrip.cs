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
       private ArrayList ArrInt1 = new ArrayList();
        //List<ArrInt> ArrInt1 = new List<ArrInt>();
        ArrInt Arr = new ArrInt(n, m);


        // private DataGridView dataGridView1;
        private void DataGridViewInitialize() // Making our DataGrid
        {
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            int MaxRows = 3;
            dataGridView2.Columns.Add("A1", "Столбец 1");
            dataGridView2.Columns.Add("A2", "Столбец 2");
            dataGridView2.AllowUserToAddRows = false;
        }

        private void DataGridViewInitializeOdnomer() // Making our DataGrid
        {
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            int MaxRows = 3;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("A00", "ЯЧ00");
            dataGridView2.Columns.Add("A01", "ЯЧ01");
            dataGridView2.Columns.Add("A10", "ЯЧ10");
            dataGridView2.Columns.Add("A11", "ЯЧ11");
            dataGridView2.AllowUserToAddRows = false;
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
            int k = 0;
            ShowBox.Clear();
            foreach (ArrInt ar in ArrInt1)
            {
                ShowBox.Text += "Массив:" + k + ar.ToString()+"\n";
                k++;          
            }
            int i = 0;

            DataGridViewInitializeOdnomer();
            dataGridView2.ReadOnly = true;
            dataGridView2.RowCount = ArrInt1.Count;
            foreach (ArrInt ar in ArrInt1)
            {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        this.dataGridView2.Rows[i].Cells[j].Value = ar.ShowArray(j, dataGridView2.ColumnCount);
                    }
                i++;
             }
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
            int i = 0;
            dataGridView2.MultiSelect = true;
            foreach (DataGridView row in dataGridView2.Rows)
            {

            }
            
            if (dataGridView2.ColumnCount < ArrInt1.Count)
            {
                dataGridView2.ColumnCount = ArrInt1.Count;
            }
            (ArrInt)ArrInt1[i];
            Arr.Sum_All();
            foreach (ArrInt arr in ArrInt1)
            {
                int selrow = dataGridView2.CurrentRow.Index;
                if (ArrInt1.Contains(ArrInt1[selrow]))


                int Sum;
                MessageBox.Show(Convert.ToString(Sum));
            }
        }

        private void ввестиСКлавиатурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            DataGridViewInitialize();
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.ReadOnly = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ArrInt Arr = new ArrInt(n, m);
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    Arr.InputArray(Convert.ToInt16(this.dataGridView2.Rows[j].Cells[i].Value), i, j);
                }
            }
            this.ArrInt1.Add(Arr);
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.AllowUserToAddRows = false;
        }
        private void автоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrInt Arr = new ArrInt(n, m);
            ArrInt Arr2 = new ArrInt(n, m);
            Arr.InputArray();
            Arr2.InputArray();
            this.ArrInt1.Add(Arr);
            this.ArrInt1.Add(Arr2);
            MessageBox.Show("Список из 2-х массивов со случайными числами создан");
        }


        //Раздел "Работа
        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrInt1.Sort(new ArrIntSort());
            int i = 0;
            DataGridViewInitializeOdnomer();
            dataGridView2.ReadOnly = true;
            dataGridView2.RowCount = ArrInt1.Count;
            foreach (ArrInt ar in ArrInt1)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    this.dataGridView2.Rows[i].Cells[j].Value = ar.ShowArray(j, dataGridView2.ColumnCount);
                }
                i++;
            }

        }
        public class ArrIntSort : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                ArrInt r1 = new ArrInt();
                r1 = (ArrInt)obj1;
                ArrInt r2 = new ArrInt();
                r2 = (ArrInt)obj2;
                if (r1.DeterminatArray() > r2.DeterminatArray())
                {
                    return 1;
                }
                else if (r1.DeterminatArray() < r2.DeterminatArray())
                {
                    return -1;
                }
                else return 0;
            }
        }
    


    private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void очиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrInt1.Clear();
            MessageBox.Show("Все элементы из списка удалены");
        }
    }
}
