/*
 First three tasks (10/06/24) :D
 I was bored when I wrote this comment
 */

using System;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's easy to win forgiveness being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");

            //try
            //{
            //    int num1 = int.Parse(Console.ReadLine()!);
            //    int num2 = int.Parse(Console.ReadLine()!);
            //    int num3 = int.Parse(Console.ReadLine()!);
            //    int num4 = int.Parse(Console.ReadLine()!);
            //    int num5 = int.Parse(Console.ReadLine()!);

            //    Console.WriteLine(num1+num2+num3+num4+num5);

            //    if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            //    {
            //        Console.WriteLine("First number is the biggest");
            //    }
            //    if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            //    {
            //        Console.WriteLine("Second number is the biggest");
            //    }
            //    if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            //    {
            //        Console.WriteLine("Third number is the biggest");
            //    }
            //    if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            //    {
            //        Console.WriteLine("Fourth number is the biggest");
            //    }
            //    if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            //    {
            //        Console.WriteLine("Fifth number is the biggest");
            //    }

            //} catch
            //{
            //    Console.WriteLine("Not a number!!!");
            //}

            try
            {
                int number = int.Parse(Console.ReadLine()!);
                string nString = number.ToString();
                string tempString = "";
                for (int i = nString.Length; i --> 0;)
                {
                    tempString += nString[i];
                }
                Console.WriteLine(tempString);
            } catch { }
        }
    }
}
