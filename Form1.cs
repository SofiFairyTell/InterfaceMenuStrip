using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections;

namespace VP_6
{
    public partial class Form1 : Form
    {
        private const string ERR = "Ошибка";
        private const string ERR_PARS = "Введены некорректные данные";
        private const string ERR_FIND = "Необходимый объект не был найден";
        private const string ERR_LENGTH = "Необходимо соответствие длинны";
        private const string ERR_SELECTED = "Необходимо выбрать хоть одну строку";
        private  string XML_FILE_NAME = "";
        private int Length = 5;

        private ArrayList arrayOfArray = new ArrayList();

        private Array AutoGeneration()
        {
            Array autoArray = new Array((uint)Length);
            Random random = new Random();
            
            for (int i = 0; i < Length; i++)
            {
                autoArray.IntArray[i] = random.Next(10);               
            }
            
            return autoArray;
        }
       

        private int MaxN()
        {
            int maxN = 0;
            for (int i = 0; i < arrayOfArray.Count; i++)
            {
                Array a = arrayOfArray[i] as Array;
                if (a.N > maxN)
                {
                    maxN = (int)a.N;
                }
            }
            return maxN;
        }

        

        /*private void Setting()
        {
            Length = MaxN();
            for (int i = 0; i < arrayOfArray.Count; i++)
            {
                (arrayOfArray[i] as Array).N = (uint)Length;
            }
        }*/

        private void DataGridViewOutput()
        {
            //Setting();
            if (MaxN() == 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                dataGridView1.ColumnCount = MaxN();
                dataGridView1.RowCount = arrayOfArray.Count;
                for (int i = 0; i < arrayOfArray.Count; i++)
                {
                    int j;
                    Array a = arrayOfArray[i] as Array;
                    for (j = 0; j < a.N; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = a.IntArray[j];
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            arrayOfArray.Add(AutoGeneration());
            dataGridView1.ReadOnly = true;
            DataGridViewOutput();

        }

        private void сортирокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayOfArray.Sort();
            DataGridViewOutput();
        }

        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> indexToDelete = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToDelete.Count != 0)
            {
                //indexToDelete.Sort();              
                arrayOfArray.RemoveAt(indexToDelete[0]);
                indexToDelete.RemoveAt(0);
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private int[] StringToArray(string array)
        {
            if (array != "")
            {
                string[] arrayOfString = array.Split(' ');
                int[] arrayOfInt = new int[arrayOfString.Length];
                for (int i = 0; i < arrayOfString.Length; i++)
                {
                    if (Int32.TryParse(arrayOfString[i], out int newInt))
                    {
                        arrayOfInt[i] = newInt;
                    }
                    else
                    {
                        return null;
                    }
                }
                return arrayOfInt;
            }
            else
            {
                return null;
            }
        }

        private void самостоятельноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewArray arrayForm = new NewArray();
            DialogResult result = arrayForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int[] intArray = StringToArray(arrayForm.textBox1.Text);
            if (intArray != null)
            {
                arrayOfArray.Add(new Array(intArray));
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_PARS, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryToParse(out ArrayList newAArrayList)
        {
            newAArrayList = new ArrayList();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Array newArray = new Array((uint)dataGridView1.ColumnCount);
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        newArray.IntArray[j] = 0;
                    }
                    else
                    {
                        if (Int32.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out int newInt))
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

        private void изменениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ReadOnly)
            {
                dataGridView1.ReadOnly = false;
                изменениеToolStripMenuItem.Text = "Сохранить изменения";
                добалениеToolStripMenuItem.Enabled = false;
                удалениеToolStripMenuItem.Enabled = false;
                взаимодействейToolStripMenuItem.Enabled = false;
                xMLToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (TryToParse(out ArrayList newAArrayList))
                {

                    dataGridView1.ReadOnly = true;
                    arrayOfArray = newAArrayList;
                    DataGridViewOutput();
                    изменениеToolStripMenuItem.Text = "Изменение";
                    добалениеToolStripMenuItem.Enabled = true;
                    удалениеToolStripMenuItem.Enabled = true;
                    взаимодействейToolStripMenuItem.Enabled = true;
                    xMLToolStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show(ERR_PARS, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void инкрименнтМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> indexToInc = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToInc.Count != 0)
            {
                indexToInc.Sort();
                while (indexToInc.Count != 0)
                {
                    Array a = arrayOfArray[indexToInc[0]] as Array;
                    a++;
                    indexToInc.RemoveAt(0);
                }
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void дикриментToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> indexToInc = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToInc.Count != 0)
            {
                indexToInc.Sort();
                while (indexToInc.Count != 0)
                {
                    Array a = arrayOfArray[indexToInc[0]] as Array;
                    a--;
                    indexToInc.RemoveAt(0);
                }
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void массивОтсортированToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<int> indexToInc = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToInc.Count != 0)
            {
                indexToInc.Sort();
                while (indexToInc.Count != 0)
                {
                    Array a = arrayOfArray[indexToInc[0]] as Array;
                    if (!a)
                    {
                        MessageBox.Show("Массив отсортирован по убыванию");
                        
                    }
                    else
                    {
                        MessageBox.Show("Массив не отсортирован по убыванию");
                    }
                    indexToInc.RemoveAt(0);
                }
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void автоматическоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayOfArray.Add(AutoGeneration());
            DataGridViewOutput();
        }

        private void линейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewArray arrayForm = new NewArray();
            DialogResult result = arrayForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int[] intArray = StringToArray(arrayForm.textBox1.Text);
            if (intArray != null)
            {
                if (intArray.Length == Length)
                {
                    Array value = new Array(intArray);
                    int index = -1;
                    for (int i = 0; i < arrayOfArray.Count; i++)
                    {
                        Array array = arrayOfArray[i] as Array;
                        if (array == value)
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
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[index].Selected = true;
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

        private void массиваСMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = -1;
            int index = -1;
            for (int i = 0; i < arrayOfArray.Count; i++)
            {             
               Array array = arrayOfArray[i] as Array;
               int b = array.Summ();
                if (!array && b>max) {
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
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Selected = true;
            }


        }

        private void обратныйПорядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint max = 0;
            
            for (int i = 0; i < arrayOfArray.Count; i++)
            {
                Array array = arrayOfArray[i] as Array;
                if (array.N > max)
                {
                    max = array.N;
                }
            }

            for (int i = 0; i < arrayOfArray.Count; i++)
            {
                Array array = arrayOfArray[i] as Array;
                Array arr = new Array(array.N);
                if (array.N == max)
                {
                    for(uint j = array.N ; j > 0; j--)
                    {
                        arr.IntArray[array.N - j] = array.IntArray[j-1];
                    }
                arrayOfArray[i] = arr;
                
                }
            }
            DataGridViewOutput();

        }

        private void бинарныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayOfArray.Sort();
           
            DataGridViewOutput();
            NewArray arrayForm = new NewArray();
            DialogResult result = arrayForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int[] intArray = StringToArray(arrayForm.textBox1.Text);
            int index = arrayOfArray.BinarySearch(new Array(intArray));
            if (index == -1)
            {
                MessageBox.Show(ERR_FIND, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void сортировкаМассиваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> indexToSort = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToSort.Count != 0)
            {
                indexToSort.Sort();
                while (indexToSort.Count != 0)
                {
                    Array a = arrayOfArray[indexToSort[0]] as Array;
                    a.BubbleSort();
                    indexToSort.RemoveAt(0);
                }
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void сОртСПИСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            List<int> indexToSort = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToSort.Count != 0)
            {
                indexToSort.Sort();
                while (indexToSort.Count != 0)
                {
                    Array a = arrayOfArray[indexToSort[0]] as Array;
                    a.First = a.IntArray[0];
                    int b = a.Summ();
                    a.IntArray[0] = b;
                    indexToSort.RemoveAt(0);
                      
                }
            }

            arrayOfArray.Sort();

            List<int> indexToFirst = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToFirst.Count != 0) { 
                while (indexToFirst.Count != 0)
                {
                    Array a = arrayOfArray[indexToFirst[0]] as Array;
                    a.IntArray[0] = a.First;
                    indexToFirst.RemoveAt(0); 
                }

                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void сортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> indexToSort = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToSort.Count != 0)
            {
                indexToSort.Sort();
                while (indexToSort.Count != 0)
                {
                    Array a = arrayOfArray[indexToSort[0]] as Array;
                    a.BubbleSortDescending();
                    indexToSort.RemoveAt(0);

                }
                
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if ((XML_FILE_NAME != null) && (XML_FILE_NAME != ""))
            {
                Type[] Types = new Type[1];
                Types[0] = typeof(Array);
                XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), Types);
                using (FileStream XMLFile = new FileStream(XML_FILE_NAME, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(XMLFile, arrayOfArray);
                }
                this.Text = XML_FILE_NAME;
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XML_FILE_NAME = saveFileDialog1.FileName + ".xml";
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XML_FILE_NAME = openFileDialog1.FileName;
        }



        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if ((XML_FILE_NAME != null) && (XML_FILE_NAME != ""))
            {
                Type[] Types = new Type[1];
                Types[0] = typeof(Array);
                XmlSerializer deserializer = new XmlSerializer(typeof(ArrayList), Types);
                using (FileStream XMLFile = new FileStream(XML_FILE_NAME, FileMode.OpenOrCreate))
                {
                    arrayOfArray = (ArrayList)deserializer.Deserialize(XMLFile);
                    DataGridViewOutput();
                }
                this.Text = XML_FILE_NAME;
            }

        }

        private void массивОтсортированПоУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> indexToInc = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            if (indexToInc.Count != 0)
            {
                indexToInc.Sort();
                while (indexToInc.Count != 0)
                {
                    Array a = arrayOfArray[indexToInc[0]] as Array;
                    if (!a)
                    {
                        MessageBox.Show("Массив отсортирован");
                    }
                    else
                    {
                        MessageBox.Show("Массив не отсортирован");
                    }
                    indexToInc.RemoveAt(0);
                }
                DataGridViewOutput();
            }
            else
            {
                MessageBox.Show(ERR_SELECTED, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
