using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        /* Task 4
        int a = 0;
        int b = 1;
        int rA = 0;
        int rB = 0;

        try
        {
            Console.Write("Range start: ");
            rA = int.Parse(Console.ReadLine()!);

            Console.Write("Range end: ");
            rB = int.Parse(Console.ReadLine()!);
            
        }
        catch
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.Clear();
        Console.WriteLine($"Fibbonaci sequence of your range ({rA} - {rB}): ");

        while (a <= rB)
        {
            if (a >= rA)
            {
                Console.Write(a + " ");
            }
            int temp = a;
            a = b;
            b = temp + b;
        }
        */

        /* Task 5
        int a = 3;
        int b = 7;
        int temp = a;
        while (temp <= b)
        {
            for (int i = 0; i < temp; i++)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
            temp++;
        }
        */
        
        // Task 6
        char symbol = ' ';
        int length = 0;
        int orientation = 0;
        try
        {
            Console.Write("Symbol: ");
            symbol = Console.ReadLine()![0];
            Console.Write("Length: ");
            length = int.Parse(Console.ReadLine()!);
            Console.Write("Orientation (0 horizontal / 1 vertical): ");
            orientation = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < length; i++)
            {
                if (orientation == 0)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.WriteLine(symbol);
                }
            }
        }
        catch { return; }
    }
}
