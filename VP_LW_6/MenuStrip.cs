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
using System.Xml.Serialization;
using ArrIntSpace;

namespace VP_LW_6
{
    public partial class MenuStrip : Form
    {
        #region переменные
            static int n = 2;
            static int m = 2;
            private int Length = m * n;
            private const string ERR = "Ошибка";
            private const string ERR_SELECTED = "Выберите хотя бы одну строку";
            private const string ERR_FIND = "Не найдено";
            private const string ERR_LENGTH = " Длина больше или меньше 4";
            private const string ERR_PARS = "Введены неверные данные";
            private const string st1 = "Добро пожаловaть в программу!\n 1. Для создания, удаления, просмотра и сохранения данных используется раздел 'Работа с массивом'\n";
            private const string st2 = "2. Для изменения данных, для поиска, для сортировки используется раздел 'Действия над данными'\n";
            private const string st3 = "3. Программа работает с массивами размером 2х2 ";
            private const string MESS_ABOUT = st1 + st2 + st3;
          //  private string XML_FILE_NAME = "";
            private ArrayList ArrInt1 = new ArrayList();
            ArrInt Arr = new ArrInt(n, m);
        #endregion
        #region DataGridView Initializers
        private void DataGridViewInitialize() // Making our DataGrid
        {
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle(); // Defining new cell style
            columnStyle.BackColor = Color.Azure;
            columnStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            dataGridView2.Columns.Add("A1", "Столбец 1");
            dataGridView2.Columns.Add("A2", "Столбец 2");
            dataGridView2.Rows.Add(2);
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
                dataGridView2.ReadOnly = false;
            }
            private void AddButton_Click(object sender, EventArgs e)
            {
                ArrInt Arr = new ArrInt(n, m);
                dataGridView2.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView2.RowCount; i++)
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
            private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
            {
               SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "*.txt";
                saveFileDialog1.Filter = "Text files|*.txt";
                if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length >0)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true))
                    {
                        sw.WriteLine(ShowBox.Text);
                        sw.Close();
                    }
                }
            }
            private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
            {
               this.Close();
            }
        #endregion
        #region Work with data in Array
        #region Sort
            private void ПонаибольшемуколичествунулейToolStripMenuItem_Click(object sender, EventArgs e)
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
                    if (r1.Zero_Element < r2.Zero_Element)
                    {
                        return 1;
                    }
                    else if (r1.Zero_Element > r2.Zero_Element)
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
            ArrayList ArrFindList = new ArrayList();
            DialogResult result = ArrFind.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            ArrInt intArray = new ArrInt(n, m);
            for (int i = 0; i < ArrFind.FindGrid.RowCount; i++)
            {
                for (int j = 0; j < ArrFind.FindGrid.ColumnCount; j++)
                {
                    intArray.InputArray(Convert.ToInt16(ArrFind.FindGrid.Rows[j].Cells[i].Value), i, j);
                }
            }
            ShowBox.Text = "Действие: Поиск введенного массива"+"\n" + "Введенный массив:" + intArray.ToString()+"\n";
            ArrFindList.Add(intArray);
            //проверка на отсутствие данных в массиве , который ищем?
            MessageBox.Show("Данные для поиска введены", "Хорошо", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int index = -1;
                for (int i = 0; i < ArrInt1.Count; i++)
                {
                    ArrInt ArrNew = ArrInt1[i] as ArrInt;
                    ArrInt ArrFindNew = ArrFindList[0] as ArrInt;
                     if (ArrFindNew == ArrNew)
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
                    ViewArray();
                    
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[index].Selected = true;
                    ShowBox.Text += "Индекс найденного массива:" + index +"\n";
            }
        }

        private void столбец1СMAXСуммойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = -1;
            int index = -1;
            for (int i = 0; i < ArrInt1.Count; i++)
            {
                ArrInt array = ArrInt1[i] as ArrInt;
                int b = array.Sum_Column(0);
                if (b > max)
                {
                    max = b;
                    index = i;
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
                ShowBox.Text +="Действие: Поиск массива, где сумма 1го столбца максимальна"+"\n"+"Максимальная сумма в массиве:" + index + " = "+ max + "\n";
            }
        }
        private void бинарныйToolStripMenuItem_Click(object sender, EventArgs e)
            {
              ArrInt1.Sort(new ArrIntSort());
              ViewArray();
              int min = 0;
              int max = ArrInt1.Count -1;
            for (int i = 0; i < ArrInt1.Count; i++)
            {
               int mid = (min + max) / 2;
                ArrInt arrMin = ArrInt1[min] as ArrInt;
                ArrInt arrMid = ArrInt1[mid] as ArrInt;

                if (arrMin.Zero_Element > arrMid.Zero_Element)
                {
                        max = mid - 1;
                }                  
                else
                    if (arrMin.Zero_Element < arrMid.Zero_Element)
                    min = mid + 1;
                    else
                    {
                      dataGridView2.Rows[mid].Selected = true;
                    }
            }
            ShowBox.Text += "Действие: Бинарный поиск по наибольшему количеству нулей" + "\n" + "Массив:" + dataGridView2.CurrentCell.RowIndex+ "\n";
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
        }
        
        private void MenuStrip_Load(object sender, EventArgs e)
        {

        }
               
        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MESS_ABOUT,"О программе" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 2)
            {
                dataGridView2.AllowUserToAddRows = false;
            }
        }


    }
}
