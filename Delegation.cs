using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public delegate int CalculateOperation(int[] array);
    public delegate void ModifyOperation(int[] array);

    public class ArrayOperations
    {
        public static int CountNegativeElements(int[] array)
        {
            int count = 0;
            foreach (int elem in array)
            {
                if (elem < 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CalculateSum(int[] array)
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }
            return sum;
        }

        public static int CountPrimeNumbers(int[] array)
        {
            int count = 0;
            foreach (int elem in array)
            {
                if (IsPrime(elem))
                {
                    count++;
                }
            }
            return count;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
