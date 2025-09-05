using ArrayandStringLibrary.Interfaces;
using ArrayandStringLibrary.Methods;
using System;

//ConsoleApp

namespace ArrayActivity.Activities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            ArrayProcessor processor1 = new ArrayProcessor(numbers1);
            processor1.ShowArrays();
            processor1.FindInArray(null, true);
            var processor2 = new ArrayProcessor(new int[] { 10, 20, 30, 40, 50 });

            processor2.LinearSearch(20, true);
            Console.WriteLine();
            IString stringActivity = new StringProcessor();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            stringActivity.AssignWord(word);
            stringActivity.GenerateReversedWord();
            stringActivity.ShowReversedWord();

            Console.WriteLine();
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            stringActivity.AssignSentence(sentence);
            stringActivity.CountWords();
            stringActivity.ShowWordCount();
            Console.WriteLine("\nProgram finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}