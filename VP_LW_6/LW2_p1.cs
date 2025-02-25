using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.IO;

namespace ArrIntSpace
{
    public interface IArOperation
    {
        int Sum_Column(int j);
        int ShowArray(int j, int i);
        void InputArray(int k);
        void InputArray(int data, int i, int j);
        int DeterminatArray();
    }


    public class ArrInt : IArOperation
    {
        private  int[,] IntArr; //двумерный массив
        private int n, m;// строки и столбцы
        private uint k;
        #region свойства для строк и столбцов
            public int Row_N
            {
                get
                {
                    return n;
                }
                set
                {
                    if (value != 0 && value > 0)
                    {
                        n = value;
                    }
                    else
                    {
                        Console.WriteLine("Неправильный ввод");
                        n = 1;
                    }
                }
            }
            public int Col_M
            {
                get
                {
                    return m;
                }
                set
                {
                    if (value != 0 && value > 0)
                    {
                        m = value;
                    }
                    else
                    {
                        Console.WriteLine("Неправильный ввод");
                        m = 1;
                    }
                }
            }
        #endregion
        #region конструкторы
            public ArrInt(int n, int m)
            {
                Row_N = n;
                Col_M = m;
                IntArr = new int[Row_N, Col_M];
            }
            public ArrInt()
            {
                Row_N = 2;
                Col_M = 2;
                IntArr = new int[Row_N, Col_M];
                for (int i = 0; i < Row_N; i++)
                {
                    for (int j = 0; j < Col_M; j++)
                    {
                        IntArr[i, j] = i * j + 1;
                    }
                }
            }
            public ArrInt(int[] IntArray)
            {
            k = (uint)IntArray.Length;
             IntArr = new int[Row_N, Col_M];
            for (int i=0; i<Row_N;i++)
            {
                for(int j=0; j<Col_M;j++)
                {
                   IntArr[i,j] = IntArray[k];
                   k++;
                }
            }          
            }
            
         #endregion

        //ввод массива
        public void InputArray(int k)
        {
            Random r2 = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    int Num = r2.Next(k);
                    IntArr[i, j] = Num;
                }
            }
        }
        public void InputArray(int data, int i, int j)
        {
            IntArr[i, j] = data;
        }
        //вывод массива
        public int ShowArray(int p, int L)
        {
            int m = 2;
            int n = 2;
            int[] Odnomer = new int[L];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Odnomer[k] = IntArr[i, j];
                    k++;
                }
            }
            return Odnomer[p];
        }
        public int[] OnDimArray ()
        {
            int m = 2;
            int n = 2;
            int[] Odnomer = new int[m*n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Odnomer[k] = IntArr[i, j];
                    k++;
                }
            }
            return Odnomer;
        }

        public void InputArray(string line)
        {
            string[] s = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int k = 0;
                         for (int i = 0; i < n; i++)
                           {
                                for (int j = 0; j < m; j++)
                                {
                                IntArr[i, j] = int.Parse(s[k]);
                                k++;
                                }
                            }
        }


        public int DeterminatArray()
        {
            int Deter = 0;
            Deter = IntArr[0, 0] * IntArr[1, 1] - IntArr[0, 1] * IntArr[1, 0];
            return Deter;
        }
        //вычисление суммы заданного столбца
        public int Sum_Column(int j)
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += IntArr[i, j];
            }
            return Sum;
        }
        public int Sum_All()
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Sum += IntArr[i, j];
                }
            return Sum;
        }
        //вычисление количества нулевых элементов в массиве 
        //свойство, доступно только для чтения. 
        public int Zero_Element
        {
            get
            {
                int Count = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (IntArr[i, j] == 0)
                            Count++;
                    }
                }
                return Count;
            }
        }
    #region Переопределенные методы
        //одновременное увеличение на 1 и уменьшение на 1
        //возвращаемый тип это тот, тип объекты которого хотим получить
        //то есть возвращаем объекты класса ArrInt
        public static ArrInt operator ++(ArrInt obj)
        {
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    obj.IntArr[i, j] = obj.IntArr[i, j] + 1;
                }
            }
            return obj;
        }
        public static ArrInt operator --(ArrInt obj)
        {
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    obj.IntArr[i, j] = obj.IntArr[i, j] - 1;
                }
            }
            return obj;
        }
        //операции бинарный +: позволяющей 
        //сложить два массива соответствующих размерностей. 
        public static ArrInt operator +(ArrInt obj1, ArrInt obj2)
        {
            int n = obj1.n;
            int m = obj1.m;
            ArrInt obj3 = new ArrInt(n, m);
            int r1 = obj1.IntArr.GetLength(0);
            int r2 = obj2.IntArr.GetLength(1);
            if (obj1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        obj3.IntArr[i, j] = obj1.IntArr[i, j] + obj2.IntArr[i, j];
                    }
                }
                Console.WriteLine("СЛОЖИЛ!");
                return obj3;
            }
            else
            {
                Console.WriteLine("Нельзя сложить массивы");
                return obj3;
            }
        }
        //вывод содержимого массива в виде строки 
        public override string ToString()
        {
            var sb = new StringBuilder();// создаем объект - изменяемую строку символов 

            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    sb.Append($"{this.IntArr[i, j]} ");//добавляет сведения в конец текущего объекта
                }

                //sb.AppendLine(); //вернуть если надо чтобы построчно выводилось
            }

            return sb.ToString();
        }
        //констант true и false: обращение к экземпляру класса даёт 
        //значение true, если двумерный массив является квадратным;
        public static bool operator true(ArrInt obj)
        {
            int n1 = obj.n;
            int n2 = obj.m;
            if (n1 == n2)
            {
                Console.WriteLine("Квадратная матрица");
                return true;
            }
            else
            {
                Console.WriteLine("Не квадратная матрица");
                return false;
            }
        }
        public static bool operator false(ArrInt obj)
        {
            int n1 = obj.n;
            int n2 = obj.m;
            if (n1 != n2)
            {
                Console.WriteLine("Не квадратная матрица");
                return true;
            }
            else
            {
                Console.WriteLine("Квадратная матрица");
                return false;
            }
        }
    public static bool operator ==(ArrInt obj, ArrInt obj1)
        {
            int r1 = obj1.IntArr.GetLength(0);
            int r2 = obj.IntArr.GetLength(0);
            if (r1 == r2)
            {
                for (uint i = 0; i < obj1.Row_N; i++)
                {
                    for (uint j = 0; j < obj1.Col_M; j++)
                        if (obj.IntArr[i, j] != obj1.IntArr[i, j])
                        {
                            return false;
                        }
                }
                return true;
        }
            else
            {
                return false;
            }
        }
        public static bool operator !=(ArrInt obj, ArrInt obj1)
        {
            int r1 = obj1.IntArr.GetLength(0);
            int r2 = obj.IntArr.GetLength(1);
            if (r1 == r2)
            {
                for (uint i = 0; i < obj1.Row_N; i++)
                {
                    for (uint j = 0; j < obj1.Col_M; j++)
                        if (obj.IntArr[i,j] != obj1.IntArr[i,j])
                        {
                            return true;
                        }
                }
                return false;
            }
            else
            {
                return true;
            }
        }



        #endregion
    }

   
   
    
    
    
    
    
    
    
    
    
    //public class ArrCollection : ICollection<ArrInt>
    // {
    //  public void Add(ArrInt Arr)
    //  {
    //    Arr.InputArray();
    //  }
    //  public void Clear()
    //     {
    //          Arr.Clear();
    //     }
    //}
}
