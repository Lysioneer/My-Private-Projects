using System;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 8, 7, 5, 2, 6, 8, 1 };
            string result = PhoneNumber(numbers);
        }

        public static string PhoneNumber(int[] numbers)
        {
            string result = "";

            int[] firstPart = { numbers[0], numbers[1], numbers[2] };
            int[] middlePart = { numbers[3], numbers[4], numbers[5] };
            int[] lastPart = { numbers[6], numbers[7], numbers[8], numbers[9] };

            string first = "";
            for (int i = 0; i < firstPart.Length; i++)
            {
                first += firstPart[i];
            }
            result = "(" + first + ") ";

            for (int i = 0; i < middlePart.Length; i++)
            {
                result += middlePart[i];
            }
            result = result + "-";

            for (int i = 0; i < lastPart.Length; i++)
            {
                result += lastPart[i];
            }

            return result;
        }
    }
}
