using System;
using System.Collections.Generic;

namespace AlgosForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st exercise CollatzSequence

            //int input = Convert.ToInt32(Console.ReadLine());

            //List<int> numbers = new();

            //while (input != 1)
            //{
            //    numbers.Add(input);
            //    input = getCollatzSequenceFor(input);
            //}

            //numbers.Add(1);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // 2nd exercise MatrixRotate

            //int[,] matrix = 
            //{
            //    { 5, 7, 3},
            //    { 2, 9, 0},
            //    { 2, 2, 5}
            //};

            //int[,] rotatedMatrix = MatrixRotate(matrix);

            //for (int i = 0; i < (int)Math.Sqrt(Convert.ToDouble(matrix.Length)); i++)
            //{
            //    for (int j = 0; j < (int)Math.Sqrt(Convert.ToDouble(matrix.Length)); j++)
            //    {
            //        Console.Write(rotatedMatrix[i,j] + ", ");
            //    }
            //}

            // 3rd exercise Which are in?

            //string[] a1 = {"arp", "live", "strong"};
            ////string[] a1 = { "tarp", "mice", "bull" };
            //string[] a2 = {"lively", "alive", "harp", "sharp", "armstrong" };

            //string[] result = new string[6];

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    for (int j = 0; j < a2.Length; j++)
            //    {
            //        if (a2[j].Contains(a1[i]))
            //        {
            //            result[i] = a1[i];
            //        }
            //    }
            //}
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            // 4th exercise Look and say sequence generator

            //string a = "1";
            //int amount = Convert.ToInt32(Console.ReadLine());

            //string result = LookAndSay(a, amount);

            //Console.WriteLine(result);

            // 5th exercise Towers of Hanoi

            //    List<int> stackA = new();
            //    List<int> stackB = new();
            //    List<int> stackC = new();

            //    int amountDisk = 5;

            //    for (int i = 0; i < amountDisk; i++)
            //    {
            //        stackA.Add(i);
            //    }

            //    while (stackC.Count != amountDisk)
            //    {
            //        if (stackB.Count == 0)
            //        {
            //            stackB.Add(stackA[stackA.Count - 1]);
            //            stackA.RemoveAt(stackA.Count - 1);
            //        }
            //        else if (stackB.Count != 0 && stackC.Count == 0)
            //        {
            //            stackC.Add(stackA[stackA.Count - 1]);
            //            stackA.RemoveAt(stackA.Count - 1);
            //        }
            //        else if (stackB.Count != 0 && stackC.Count != 0)
            //        {
            //            if (stackB[stackB.Count - 1] > stackC[stackC.Count - 1])
            //            {
            //                stackC.Add(stackB[stackB.Count - 1]);
            //                stackB.RemoveAt(stackB.Count - 1);
            //            }
            //            else if (stackB[stackB.Count - 1] < stackC[stackC.Count - 1])
            //            {
            //                stackB.Add(stackC[stackC.Count - 1]);
            //                stackC.RemoveAt(stackC.Count - 1);
            //            }
            //        }
            //    }

            // 6th exercise Mexican Wave

            //string inputString = Console.ReadLine().ToLower();

            //List<string> wave = new();

            //for (int i = 0; i < inputString.ToCharArray().Length; i++)
            //{
            //    char[] letters = inputString.ToCharArray();

            //    char letter = Convert.ToChar(letters[i].ToString().ToUpper());

            //    letters[i] = letter;

            //    string word = "";

            //    for (int j = 0; j < letters.Length; j++)
            //    {
            //        word += letters[j];
            //    }

            //    wave.Add(word);
            //}

            //foreach (var word in wave)
            //{
            //    Console.Write(word + " ");
            //}

            // 7th exercise Connect 4

            //int[,] connect4 = new int[6, 7];

            //string player1 = "a";
            //string player2 = "b";

            //string result = Connect4(connect4, player1, player2);

            // 8th exercise Moving zeros

            //int[] numbers = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            //List<int> listNumbers = new();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    listNumbers.Add(numbers[i]);
            //}

            //for (int i = 0; i < listNumbers.Count; i++)
            //{
            //    if (listNumbers[i] is 0)
            //    {
            //        int temp = listNumbers[i];
            //        listNumbers.RemoveAt(i);
            //        listNumbers.Add(temp);
            //    }
            //}

            //int[]  result = listNumbers.ToArray();

            //foreach (var number in result)
            //{
            //    Console.Write(number + " ");
            //}

            // 9th exercise Matrix Rotate

            //int[,] matrix =
            //{
            //    { 6, 8, 9},
            //    { 3, 5, 4},
            //    { 1, 2, 2}
            //};

            //int arraySize = Convert.ToInt32(Math.Sqrt(matrix.Length));

            //int[,] rotated = new int[arraySize, arraySize];

            //int rotatedCol = 0;
            //int rotatedRow = 0;

            //for (int col = 0; col < arraySize; col++)
            //{
            //    for (int row = arraySize - 1; row >= 0; row--)
            //    {
            //        rotated[rotatedRow, rotatedCol] = matrix[row, col];
            //        rotatedCol ++;
            //    }
            //    rotatedRow ++;
            //    rotatedCol = 0;
            //}

            //for (int i = 0; i < arraySize; i++)
            //{
            //    for (int j = 0; j < arraySize; j++)
            //    {
            //        Console.Write(rotated[i,j]);
            //    }
            //}

            //Console.WriteLine();

            //// Mirrored Matrix

            //int[,] mirrored = new int[arraySize, arraySize];

            //for (int row = 0; row < arraySize; row++)
            //{
            //    for (int col = 0; col < arraySize; col++)
            //    {
            //        mirrored[row, col] = matrix[col, row];
            //    }
            //}
            //for (int i = 0; i < arraySize; i++)
            //{
            //    for (int j = 0; j < arraySize; j++)
            //    {
            //        Console.Write(mirrored[i,j]);
            //    }
            //}

            //Console.WriteLine();

            //int[,] mirroredAgain = new int[arraySize, arraySize];

            //for (int row = 0; row < arraySize; row++)
            //{
            //    for (int col = 0; col < arraySize; col++)
            //    {
            //        mirroredAgain[row, col] = matrix[col, row];
            //    }
            //}
            //for (int i = 0; i < arraySize; i++)
            //{
            //    for (int j = 0; j < arraySize; j++)
            //    {
            //        Console.Write(mirroredAgain[i, j]);
            //    }
            //}

            // 10th exercise First non-repeating char

            //string input = Console.ReadLine();

            //char[] dividedInput = input.ToCharArray();

            //string result = "";

            //for (int i = 0; i < dividedInput.Length; i++)
            //{
            //    for (int j = 0; j < dividedInput.Length; j++)
            //    {
            //        if (!(dividedInput[i].Equals(dividedInput[j])))
            //        {

            //        }


            //    }
            //}

            //Console.WriteLine(result);

            // 11th exercise clearing string

        }

        //public static int getCollatzSequenceFor(int input)
        //{
        //    if (input % 2 == 0)
        //    {
        //        return input / 2;
        //    }
        //    else
        //    {
        //        return input * 3 + 1;
        //    }
        //}

        //public static int[,] MatrixRotate(int[,] inputMatrix)
        //{
        //    int size = (int)Math.Sqrt(Convert.ToDouble(inputMatrix.Length));

        //    Console.WriteLine(size);

        //    int[,] newMatrix = new int[size, size];

        //    for (int i = 0; i < size; i++)
        //    {
        //        int[] oneLine = new int[size];
        //        for (int j = 0; j < size; j++)
        //        {
        //            oneLine[j] = inputMatrix[j, i];
        //        }

        //        for (int k = 0; k < oneLine.Length; k++)
        //        {

        //            newMatrix[i, k] = oneLine[k];

        //        }

        //    }

        //    return newMatrix;
        //}

        //public static string LookAndSay(string a, int amount)
        //{
        //    for (int i = 0; i < amount; i++)
        //    {



        //    }


        //    return 0;
        //}

        //public static string Connect4(int[,] connect4, string a, string b)
        //{
        //    if (connect4 is null)
        //    {
        //        connect4 = new int[,]
        //        {
        //            { 0, 0, 0, 0, 0, 0, 0},
        //            { 0, 0, 0, 0, 0, 0, 0},
        //            { 0, 0, 0, 0, 0, 0, 0},
        //            { 0, 0, 0, 0, 0, 0, 0},
        //            { 0, 0, 0, 0, 0, 0, 0},
        //            { 0, 0, 0, 0, 0, 0, 0}
        //        };

        //        for (int i = 0; i < 7; i++)
        //        {
        //            for (int j = 0; j < 6; j++)
        //            {
        //                Console.Write(connect4[i,j]);
        //            }
        //        }
        //        Console.Read();
        //    }



        //    return null;
        //}

    }
}
