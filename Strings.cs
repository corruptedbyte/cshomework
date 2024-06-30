using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /*
            string str = "Hello, World!";
            string userStr;
            int position;
            Console.WriteLine("Enter your string:");
            userStr = Console.ReadLine()!;
            Console.WriteLine("Enter your position:");
            position = int.Parse(Console.ReadLine()!);
            str = str.Insert(position, userStr);
            Console.WriteLine(str);
            */
            #endregion

            #region Task 2
            /*

            string str;
            string temp;

            Console.WriteLine("Enter your string 1: ");

            str = Console.ReadLine()!;

            temp = new string(str.Reverse().ToArray());
            if (str.CompareTo(temp) == 0)
            {
                Console.WriteLine("Is a palindrom");
            }
            else
            {
                Console.WriteLine("Isn't a palindrom");
            }
             
            */
            #endregion

            #region Task 3
            /*
            
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            int totalChar = str.Length;
            int lowerCaseCount = 0;
            int upperCaseCount = 0;

            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    lowerCaseCount++;
                }
                else if (char.IsUpper(c))
                {
                    upperCaseCount++;
                }
            }

            double lowerCasePercentage = (double)lowerCaseCount / totalChar * 100;
            double upperCasePercentage = (double)upperCaseCount / totalChar * 100;

            Console.WriteLine($"Total characters: {totalChar}");
            Console.WriteLine($"Total of lowercase letters: {lowerCaseCount} ({lowerCasePercentage:F2}%)");
            Console.WriteLine($"Total of uppercase letters: {upperCaseCount} ({upperCasePercentage:F2}%)");
            
            */
            #endregion

            #region Task 4
            /* 
            
            string[] array = { "military", "helmet", "rifle", "cqb" };
            int targetLength = 6;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length >= targetLength)
                {
                    if (array[i].Length == 3)
                    {
                        array[i] = new string('$', array[i].Length);
                    }

                    else
                    {
                        array[i] = array[i].Substring(0, array[i].Length - 3) + "$$$";
                    }
                }
            }
            foreach (var word in array)
            {
                Console.WriteLine(word);
            }

             */
            #endregion

            #region Task 5
            /*
            
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine("Enter index: ");
            int num = int.Parse(Console.ReadLine()!);
            string[] words = str.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            if (num <= 0 || num > words.Length)
            {
                Console.WriteLine("There is no word at this position in the text.");
            }
            else
            {
                Console.WriteLine("The word at index " + num + " is: " + words[num - 1]);
            }

             */
            #endregion

            #region Task 6
            /*
            string input = "I           love    whitespa   c e    and   u s  l e s s    s p a  c  i n       g";

            Console.WriteLine("Original string: ");
            Console.WriteLine($"'{input}'");

            input = input.Trim();

            string[] word1 = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Join("*", word1);

            Console.WriteLine("Formatted string: ");
            Console.WriteLine($"'{result}'");
             */
            #endregion

            #region Task 7
            /*
            StringBuilder sb = new StringBuilder();
            string input;

            Console.WriteLine("Enter words (use a dot to separate) > ");

            do
            {
                input = Console.ReadLine()!.Trim();

                if (!input.EndsWith("."))
                {
                    sb.Append(input);
                    sb.Append(", ");
                }
            } while (!input.EndsWith("."));

            string result1 = sb.ToString().TrimEnd(',', ' ');
            Console.WriteLine("Result: ");
            Console.WriteLine(result1);
             */
            #endregion
        }
    }
}
