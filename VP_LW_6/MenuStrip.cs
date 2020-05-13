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
        private int Length = 4;
        private const string ERR = "Ошибка";
        private const string ERR_SELECTED = "Выберите хотя бы одну строку";
        private const string ERR_FIND = "Не найдено";
        private const string ERR_LENGTH = " Введены неверные данные";
        private const string ERR_PARS = "Длина больше или меньше 4";
                
        private ArrayList ArrIntList = new ArrayList();
      //  ArrIntOne Arr = new ArrIntOne();

        #region DataGridView Initializers
        private void DataGridViewInitialize() // Making our DataGrid
        {
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
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
            foreach (ArrIntOne ar in ArrIntList)
            {
                ShowBox.Text += "Массив:" + k + ar.ToString() + "\n";
                k++;
            }
            int i = 0;
            DataGridViewInitializeOdnomer();
            dataGridView2.ReadOnly = true;
            dataGridView2.RowCount = ArrIntList.Count;
            foreach (ArrIntOne ar in ArrIntList)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    this.dataGridView2.Rows[i].Cells[j].Value = ar.ShowArray(j);
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
            ArrIntOne Arr = new ArrIntOne();
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    Arr.InputArray(Convert.ToInt16(this.dataGridView2.Rows[j].Cells[i].Value), i);
                }
            }
            this.ArrIntList.Add(Arr);
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.AllowUserToAddRows = false;
        }
        private void АвтоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrIntOne Arr = new ArrIntOne();
            ///ArrIntOne Arr2 = new ArrIntOne();
            Arr.InputArray();
            //Arr.InputArray(5);
            this.ArrIntList.Add(Arr);
            //this.ArrIntList.Add(Arr);
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
                    if (dataGridView2.ColumnCount < ArrIntList.Count)
                    {
                        dataGridView2.ColumnCount = ArrIntList.Count;
                    }
                    foreach (ArrIntOne arr in ArrIntList)
                    {
                        int selrow = dataGridView2.SelectedCells[i].RowIndex;
                        // dataGridView2.Rows[i].Cells[0].Value = arr.Sum_Column(1);
                        int Sum = arr.Sum();
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
            ArrIntList.Sort(new ArrIntSort());
            int i = 0;
            DataGridViewInitializeOdnomer();
            dataGridView2.ReadOnly = true;
            dataGridView2.RowCount = ArrIntList.Count;
            foreach (ArrIntOne ar in ArrIntList)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    this.dataGridView2.Rows[i].Cells[j].Value = ar.ShowArray(j);
                }
                i++;
            }

        }
        public class ArrIntSort : IComparer
                {
                    int IComparer.Compare(object obj1, object obj2)
                    {
                        ArrIntOne r1 = new ArrIntOne();
                        r1 = (ArrIntOne)obj1;
                        ArrIntOne r2 = new ArrIntOne();
                        r2 = (ArrIntOne)obj2;
                        if (r1.Sum() > r2.Sum())
                        {
                            return 1;
                        }
                        else if (r1.Sum() < r2.Sum())
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
                    ArrIntOne value = new ArrIntOne(intArray);
                    int index = -1;                    
                    if (index == -1)
                        for (int i = 0; i<ArrIntList.Count;i++)
                        {
                            ArrIntOne ArrNew = ArrIntList[i] as ArrIntOne;
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
        private bool TryToParse(out ArrayList NewArrIntList)
        {
            NewArrIntList = new ArrayList();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                ArrIntOne newArray = new ArrIntOne();
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value == null)
                    {
                        newArray.IntArrOne[j] = 0;
                    }
                    else
                    {
                        if (Int32.TryParse(dataGridView2.Rows[i].Cells[j].Value.ToString(), out int newInt))
                        {
                            newArray.IntArrOne[j] = newInt;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                NewArrIntList.Add(newArray);
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
            ArrIntList.Clear();
            ViewArray();
            MessageBox.Show("Все элементы из списка удалены");
        }
        private void ВыбранныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> IndexToDelete = dataGridView2.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (IndexToDelete.Count != 0)
            {
                    ArrIntList.RemoveAt(IndexToDelete[0]);
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
                            ArrIntOne a = ArrIntList[IndexToInc[0]] as ArrIntOne;
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
                            ArrIntOne a = ArrIntList[IndexToInc[0]] as ArrIntOne;
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
