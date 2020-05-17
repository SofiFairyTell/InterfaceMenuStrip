using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_6
{
    public class Array  :  IComparable
    {

        public int First { get; set; }

        private int[] intArray;

        public int[] IntArray
        {
            get
            {
                return intArray;
            }
            set
            {
                if(value != null)
                {
                    if(value.Length == n) {
                        intArray = value;
                    }
                    else
                    {
                        n = (uint)value.Length;
                        intArray = value;
                    }
                }
                else
                {
                    intArray = null;
                }
            }

        }

        public override string ToString()
        {
            string ArrayToString = "";
            if(intArray.Length !=0) 
            {
                ArrayToString = ArrayToString + intArray[0].ToString();
            }
            return ArrayToString;
        }

        private uint n;

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
                    intArray = null;
                    n = 0;
                }
                else if (value > n)
                {
                    int[] newIntArray = new int[value];
                    for (uint i = 0; i < n; i++)
                    {
                        newIntArray[i] = IntArray[i];
                    }
                    n = value;
                    intArray = newIntArray;
                }
                else if (value < n)
                {
                    int[] newIntArray = new int[value];
                    for (uint i = 0; i < value; i++)
                    {
                        newIntArray[i] = intArray[i];
                    }
                    n = value;
                    intArray = newIntArray;
                }
            }
        }

        public Array(uint n)
        {
            if (n != 0)
            {
                this.n = n;
                intArray = new int[n];
            }
            else
            {
                this.n = 0;
                intArray = null;
            }
        }

        public Array(uint n, int[] IntArray)
        {
            if (n != 0)
            {
                this.n = n;
                this.IntArray = new int[n];
                if (n > IntArray.Length)
                {
                    for (uint i = 0; i < IntArray.Length; i++)
                    {
                        this.IntArray[i] = IntArray[i];
                    }
                }
                else
                {
                    for (uint i = 0; i < n; i++)
                    {
                        this.IntArray[i] = IntArray[i];
                    }
                }
            }
            else
            {
                this.n = 0;
                this.IntArray = null;
            }
        }

        public Array(int[] IntArray)
        {
            n = (uint)IntArray.Length;
            this.IntArray = IntArray;
        }

        public Array()
        {
            n = 0;
            IntArray = null;
        }


        public void KeyboardInput()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0}-й элемент массива: ", i);
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void ConsoleOutput()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }
            Console.WriteLine();
        }

        public void BubbleSort()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
        }

        public void BubbleSortDescending()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n - 1; j++)
                {
                    if (intArray[j] < intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
        }

        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
                summ = summ + intArray[i];
            return summ;
        }


        public static Array operator ++(Array a)
        {
            for (int i = 0; i < a.n; i++)
            {
                a.intArray[i]++;
            }
            return a;
        }

        public static Array operator --(Array a)
        {
            for (int i = 0; i < a.n; i++)
            {
                a.intArray[i]--;
            }
            return a;
        }

        public static bool operator !(Array a)
        {
            for (int i = 0; i < a.n - 1; i++)
            {
                if (a.intArray[i] < a.intArray[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static Array operator *(Array a1, Array a2)
        {
            uint maxN, minN;
            if (a1.n > a2.n)
            {
                maxN = a1.n;
                minN = a2.n;
            }
            else
            {
                maxN = a2.n;
                minN = a1.n;
            }
            Array aNew = new Array(maxN);
            for (uint i = 0; i < minN; i++)
            {
                aNew.intArray[i] = a1.intArray[i] * a2.intArray[i];
            }
            return aNew;
        }

        public static bool operator true(Array array)
        {
            uint count = 0;
            for (uint i = 0; i < array.n; i++)
            {
                if (array.intArray[i] != 0)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator false(Array array)
        {
            uint count = 0;
            for (uint i = 0; i < array.n; i++)
            {
                if (array.intArray[i] != 0)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Array a1, Array a2)
        {
            if (a1.N == a2.N)
            {
                for (uint i = 0; i < a1.N; i++)
                {
                    if (a1.IntArray[i] != a2.IntArray[i])
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

        public static bool operator !=(Array a1, Array a2)
        {
            if (a1.N == a2.N)
            {
                for (uint i = 0; i < a1.N; i++)
                {
                    if (a1.IntArray[i] != a1.IntArray[i])
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

        public static bool operator <(Array a1, Array a2)
        {
            uint minN;
            if (a1.N > a2.N)
            {
                minN = a2.N;
            }
            else
            {
                minN = a1.N;
            }
            for (uint i = 0; i < minN; i++)
            {
                if (a1.IntArray[i] > a2.IntArray[i])
                {
                    return false;
                }
                else if (a1.IntArray[i] < a2.IntArray[i])
                {
                    return true;
                }
            }
            if (a1.N >= a2.N)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(Array a1, Array a2)
        {
            uint minN;
            if (a1.N > a2.N)
            {
                minN = a2.N;
            }
            else
            {
                minN = a1.N;
            }
            for (uint i = 0; i < minN; i++)
            {
                if (a1.IntArray[i] > a2.IntArray[i])
                {
                    return true;
                }
                else if (a1.IntArray[i] < a2.IntArray[i])
                {
                    return false;
                }
            }
            if (a1.N > a2.N)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(object other)
        {
            if (this == (other as Array)) return 0;
            else if (this < (other as Array)) return -1;
            else return 1;
        }

    }
}
