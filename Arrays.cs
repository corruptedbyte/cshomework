using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Task 1
            /*
            int even = 0;
            int odd = 0;
            int unique = 0;

            int[] arr = new int[] {1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,0};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp++;
                    }
                }
                if (temp == 1)
                {
                    unique++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Even numbers: {even}\nOdd numbers: {odd}\nUnique numbers: {unique}");
             
            */
            #endregion
            #region Task 2

            /*
            

            int[] arr = new int[] { 1, 1, 2, 3, 3, 3, 4, 4, 5, 6, 7, 8, 9, 9, 10 };

            int val = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < val)
                {
                    Console.WriteLine(arr[i] + $" is less than " + val);
                }
                else
                {
                    Console.WriteLine(arr[i] + $" is bigger than " + val);
                }
            }
            */
            #endregion
            #region Task 3
            /*
            Random rand = new Random();
            double[] A = new double[5];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"#{i} > ");
                A[i] = double.Parse(Console.ReadLine()!);
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(i + " ");
            }

            int countEven = 0;

            double min = double.MinValue;
            double max = double.MaxValue;

            double sum = 0;
            double product = 1;


            foreach (int a in A)
            {
                if (a < min) { min = a; }
                else if (a > max) { max = a; }
                sum += a;
                product *= a;
                if (a % 2 == 0)
                {
                    countEven++;
                }
            }

            double[,] B = new double[4, 3];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i,j] = Math.Round(rand.NextDouble(), 2);
                }
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double sumOdd = 0;
            for (int j = 1; j < B.GetLength(1); j += 2)
            {
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    sumOdd += B[i, j];
                }
            }
            */
            #endregion
            #region Task 4 & 5
            /*
            int[,] arr = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-100, 100);
                }
            }


            Console.WriteLine("2D Array: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }


            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[] array1 = new int[rows * cols];

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1[index] = arr[i, j];
                    index++;
                }
            }


            int max = array1[0];
            int min = array1[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                    maxIndex = i;
                }
                if (array1[i] < min)
                {
                    min = array1[i];
                    minIndex = i;
                }
            }

            int sum = 0;

            if (maxIndex > minIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    sum += array1[i];
                }
            }
            else
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    sum += array1[i];
                }
            }

            Console.WriteLine("Max Number: " + max);
            Console.WriteLine("Min Number: " + min);
            Console.WriteLine("Sum between Max and Min: " + sum);

            int[] array = { 10, 7, 12, 4, 8, 5, 9 };

            int minA = array[0];
            int count = 0;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] - minA) == 5)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count}");
            */
            #endregion
        }
    }
}
