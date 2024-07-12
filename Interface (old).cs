using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    interface IOutput
    {
        void Display();
        void Show();
        void Show(string info);
    }
    public class Array : IOutput
    {
        private int[] data;

        public Array(int[] data)
        {
            this.data = data;
        }

        public void Show()
        {
            foreach (int elem in data)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.Write(info + ": ");
            foreach (int elem in data)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }

        internal string Search(int v)
        {
            throw new NotImplementedException();
        }

        internal string Avg()
        {
            throw new NotImplementedException();
        }

        internal static void Sort(int[] array2)
        {
            throw new NotImplementedException();
        }

        internal static void Reverse(int[] array2)
        {
            throw new NotImplementedException();
        }

        void IOutput.Display()
        {
            throw new NotImplementedException();
        }

        internal void PrintArray()
        {
            throw new NotImplementedException();
        }

        internal void SortAsc()
        {
            throw new NotImplementedException();
        }

        internal void SortDesc()
        {
            throw new NotImplementedException();
        }

        internal void SortByParam(bool v)
        {
            throw new NotImplementedException();
        }
    }
    public class Array1 : IMath
    {
        private int[] elements;

        public Array1(int[] initialElements)
        {
            elements = initialElements;
        }

        public int Max()
        {
            int max = elements[0];
            foreach (int element in elements)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = elements[0];
            foreach (int element in elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return (float)sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int element in elements)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine("Array elements: " + string.Join(", ", elements));
        }
    }
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    public class Array2 : ISort
    {
        private int[] array2;

        public Array2(int[] array22)
        {
            array2 = array22;
        }

        public void SortAsc()
        {
            Array2.Sort(array2);
        }

        private static void Sort(int[] array)
        {
            throw new NotImplementedException();
        }

        public void SortDesc()
        {
            Array.Sort(array2);
            Array.Reverse(array2);
        }

        private static void Reverse(int[] array)
        {
            throw new NotImplementedException();
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void PrintArray()
        {
            Console.WriteLine(string.Join(", ", array2));
        }
    }
}
