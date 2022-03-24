using System;
using System.Linq;

namespace StopSpinningMyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = ModifiedString(input);

            Console.WriteLine(result);
        }
        public static string ModifiedString(string input)
        {
            string[] dividedInput = input.Split(" ");

            for (int i = 0; i < dividedInput.Length; i++)
            {
                if (dividedInput[i].Length >= 5)
                {
                    char[] s = dividedInput[i].ToCharArray();
                    Array.Reverse(s);
                    dividedInput[i] = new string(s);
                }
            }

            string result = "";

            for (int i = 0; i < dividedInput.Length; i++)
            {
                result += dividedInput[i];
            }

            return result;
        }
    }
}
