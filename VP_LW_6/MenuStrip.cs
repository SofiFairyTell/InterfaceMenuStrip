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
        private int Length = m * n;
        private const string ERR = "Ошибка";
        private const string ERR_SELECTED = "Выберите хотя бы одну строку";
        private const string ERR_FIND = "Не найдено";
        private const string ERR_LENGTH = " Введены неверные данные";
        private const string ERR_PARS = "Длина больше или меньше 4";
        private ArrayList ArrInt1 = new ArrayList();
        ArrInt Arr = new ArrInt(n, m);

        #region DataGridView Initializers
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
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("A00", "ЯЧ00");
            dataGridView2.Columns.Add("A01", "ЯЧ01");
            dataGridView2.Columns.Add("A10", "ЯЧ10");
            dataGridView2.Columns.Add("A11", "ЯЧ11");
            dataGridView2.AllowUserToAddRows = false;
        }

        #endregion
       
        #region Work with Array
        private void ViewArray()
        {
            int k = 0;
            ShowBox.Clear();
            foreach (ArrInt ar in ArrInt1)
            {
                ShowBox.Text += "Массив:" + k + ar.ToString() + "\n";
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
        private void ВвестиСКлавиатурыToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void АвтоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrInt Arr = new ArrInt(n, m);
            ArrInt Arr2 = new ArrInt(n, m);
            Arr.InputArray();
            Arr2.InputArray();
            this.ArrInt1.Add(Arr);
            this.ArrInt1.Add(Arr2);
            MessageBox.Show("Список из 2-х массивов со случайными числами создан");
        }
        private void ПросмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewArray();
        }
        private void РедактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ВыгрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Work with data in Array
       
        #region Sum
        private void ПоНомеруСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void ВыбранныхМассивовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sort
        private void ПоВозрастаниюЗначенияОпределителяToolStripMenuItem_Click(object sender, EventArgs e)
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
        #endregion

        #region Find
        private void линейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm ArrFind = new FindForm();
            DialogResult result = ArrFind.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int[] intArray = StringToArray(ArrFind.FindTextBox.Text);
            if(intArray!=null)
            {
                if(intArray.Length == Length)
                {
                    ArrInt value = new ArrInt(intArray);
                    int index = -1;                    if (index == -1)

                    for (int i = 0; i<ArrInt1.Count;i++)
                    {
                        ArrInt ArrNew = ArrInt1[i] as ArrInt;
                        if (ArrNew == value)
                        {
                            index = i;
                            break;
                        }
                    }
                    if (index == -1)
                    {
                        MessageBox.Show(ERR_FIND, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridView2.ClearSelection();
                        dataGridView2.Rows[index].Selected = true;
                    } 
                }
                else
                {
                    MessageBox.Show(ERR_LENGTH, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
            else
                {
                MessageBox.Show(ERR_PARS, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private int[] StringToArray(string Arr)
        {
            if(Arr!="")
            {
                string[] ArrayOfString = Arr.Split(' ');
                int[] ArrOfInt = new int[ArrayOfString.Length];
                for(int i=0;i< ArrayOfString.Length;i++)
                {
                    if(Int32.TryParse(ArrayOfString[i],out int newInt))
                    {
                        ArrOfInt[i] = newInt;
                    }
                    else
                    {
                        return null;
                    }
                }
                return ArrOfInt;
            }
            else
            {
                return null;
            }
        }
        private bool TryToParse(out ArrayList newAArrayList)
        {
            newAArrayList = new ArrayList();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                ArrInt newArray = new ArrInt();
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value == null)
                    {
                        newArray.IntArray[j] = 0;
                    }
                    else
                    {
                        if (Int32.TryParse(dataGridView2.Rows[i].Cells[j].Value.ToString(), out int newInt))
                        {
                            newArray.IntArray[j] = newInt;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                newAArrayList.Add(newArray);
            }
            return true;
        }
        private void бинарныйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion




        #region Delete
        private void ОчиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewArray();
            ArrInt1.Clear();
            ViewArray();
            MessageBox.Show("Все элементы из списка удалены");
        }
        private void ВыбранныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> IndexToDelete = dataGridView2.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (IndexToDelete.Count != 0)
            {
                    ArrInt1.RemoveAt(IndexToDelete[0]);
                    IndexToDelete.RemoveAt(0);
                    ViewArray();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Increment and Decrement
        private void УвеличитьВсеНа1ToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    ShowBox.Clear();
                    List<int> IndexToInc = dataGridView2.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                    if (IndexToInc.Count != 0)
                    {
                        IndexToInc.Sort();
                        while (IndexToInc.Count != 0)
                        {
                            ArrInt a = ArrInt1[IndexToInc[0]] as ArrInt;
                            a++;
                            IndexToInc.RemoveAt(0);
                            ViewArray();
                        }
                    }
                    else
                    {
                        MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
        private void УменьшитьВсеНа1ToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    ShowBox.Clear();
                    List<int> IndexToInc = dataGridView2.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                    if (IndexToInc.Count != 0)
                    {
                        IndexToInc.Sort();
                        while (IndexToInc.Count != 0)
                        {
                            ArrInt a = ArrInt1[IndexToInc[0]] as ArrInt;
                            a--;
                            IndexToInc.RemoveAt(0);
                            ViewArray();
                        }
                    }
                    else
                    {
                        MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
        #endregion
       
       
        #endregion

        public MenuStrip()
        {
            InitializeComponent();
            string Arr_file;        
        }
        
        private void MenuStrip_Load(object sender, EventArgs e)
        {

        }
               
        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловaть в программу!","О программе" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}
