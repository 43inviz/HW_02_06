using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///TASK 5
            int[,] arr = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 9);
                }
            }

            MinMax minMax = new MinMax(arr);
            minMax.searchMaxInArr();
            minMax.searchMinInArr();
            Console.WriteLine($"Min: {minMax.getMin()}, Max: {minMax.getMax()}");
            minMax.showArr();


            ///TASK 7
            ///

            reverseString stringRev = new reverseString("1234");
            stringRev.reverseInputString();
            Console.WriteLine($"Reverse string: {stringRev.getOutputString()}");
            Console.ReadKey();

            //TASK 9
            string enterString;
            string searchedWord;

            Console.Write("Enter string: ");
            enterString = Console.ReadLine();
            Console.Write("Enter searched word: ");
            searchedWord = Console.ReadLine();


            WordCountInSentence wordCounter = new WordCountInSentence(enterString, searchedWord);
            wordCounter.wordCount();
            Console.WriteLine($"Count : {wordCounter.getCount()}");
            Console.ReadKey();

        }
    }
}
