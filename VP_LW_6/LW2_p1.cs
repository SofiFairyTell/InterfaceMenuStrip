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
        int Sum();
        int ShowArray(int p);
        void InputArray(int data, int i);
       // void InputArray(int data, int i);
       // int DeterminatArray();
    }

    
    public class ArrIntOne: IArOperation
    {
        private  int[] intArrOne; 
       
        public int[] IntArrOne
        {
            get
            {
                return IntArrOne;
            }
            set
            {
                if( value != null)
                {
                    if(value.Length == n) {
                        IntArrOne= value;
                    }
                    else
                    {
                        n = (uint)value.Length;
                        IntArrOne = value;
                    }
                }
                else
                {
                    IntArrOne = null;
                }
            }

        }
        public int ShowArray(int p)
        {
            return IntArrOne[p];
        }
        public void InputArray(int data, int i)
        {
            IntArrOne[i] = data;
        }

        public void InputArray(int random)
        {
            Random r2 = new Random();
            for (int i = 0; i < n; i++)
            {
                    int Num = r2.Next(10);
                    IntArrOne[i] = Num;
                }
            }
        private uint n;// строки и столбцы
        public ArrIntOne(uint n)
        {
            if (n != 0)
            {
                this.n = n;
                intArrOne = new int[n];
            }
            else
            {
                this.n = 0;
                intArrOne = null;
            }
        }
        public ArrIntOne(uint n, int[] IntArray)
        {
            if (n != 0)
            {
                this.n = n;
                this.IntArrOne = new int[n];
                if (n > IntArray.Length)
                {
                    for (uint i = 0; i < IntArray.Length; i++)
                    {
                        this.IntArrOne[i] = IntArray[i];
                    }
                }
                else
                {
                    for (uint i = 0; i < n; i++)
                    {
                        this.IntArrOne[i] = IntArray[i];
                    }
                }
            }
            else
            {
                this.n = 0;
                this.IntArrOne = null;
            }
        }
        public override string ToString()
        {
            string ArrayToString = "";
            if (IntArrOne.Length != 0)
            {
                ArrayToString = ArrayToString + IntArrOne[0].ToString();
            }
            return ArrayToString;
        }
        public uint N
        {
            get
            {
                return n;
            }
            set
            {
                if (value == 0)
                {
                    IntArrOne = null;
                    n = 0;
                }
                else if (value > n)
                {
                    int[] newIntArray = new int[value];
                    for (uint i = 0; i < n; i++)
                    {
                        newIntArray[i] = IntArrOne[i];
                    }
                    n = value;
                    IntArrOne = newIntArray;
                }
                else if (value < n)
                {
                    int[] newIntArray = new int[value];
                    for (uint i = 0; i < value; i++)
                    {
                        newIntArray[i] = IntArrOne[i];
                    }
                    n = value;
                    IntArrOne = newIntArray;
                }
            }
        }
        public ArrIntOne(int[] IntArray)
        {
            n = (uint)IntArray.Length;
            this.IntArrOne = IntArray;
        }

        public ArrIntOne()
        {
            n = 0;
            IntArrOne = null;
        }

        public int Sum()
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += IntArrOne[i];
            }
            return Sum;
        }
        //вывод содержимого массива в виде строки 
        // public override string ToString()
        // {
        //     var sb = new StringBuilder();// создаем объект - изменяемую строку символов 

        //     for (int i = 0; i < this.n; i++)
        //     {
        //             sb.Append($"№{i} = {this.IntArr[i]} ");//добавляет сведения в конец текущего объекта
        //         //sb.AppendLine(); //вернуть если надо чтобы построчно выводилось
        //     }

        //     return sb.ToString();
        // }

        public static ArrIntOne operator ++(ArrIntOne obj)
        {
            for (int i = 0; i < obj.n; i++)
            {
                obj.IntArrOne[i]++;
            }
            return obj;
        }
        public static ArrIntOne operator --(ArrIntOne obj)
        {
            for (int i = 0; i < obj.n; i++)
            {
                obj.IntArrOne[i]--;
            }
            return obj;
        }

    }



}



