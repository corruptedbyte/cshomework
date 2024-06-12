namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 0;
            int odd = 0;
            int temp = 0;

            int[] arr = new int[] { 1, 1, 2, 3, 3, 3, 4, 4, 5, 6, 7, 8, 9, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                temp += i;
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + " is even");
                    even++;
                }
                else
                {
                    odd++;
                    Console.WriteLine(arr[i] + " is odd");
                }
                if (arr[i] != arr[temp])
                {
                    Console.WriteLine(arr[i]);
                }
            }

            /*
            Console.WriteLine();
            Console.WriteLine($"Even numbers: {even}\nOdd numbers: {odd}\nUnique numbers: ");

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
        }
    }
}
