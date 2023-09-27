using System;
using static System.Console;

namespace HangMan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word = Arjun.pickWord(2);
            WriteLine(word);
            WriteLine("Hello, World!");
            for (var i = 0; i < 10; i++)
            {
                string guessedLetter = ReadLine();
                CheckLetterFunction.CheckLetter(word , guessedLetter);
            }
            for (var i = 0; i < 10; i++)
            {
                WriteLine(Sophie.OutputGallows(i));
            }
        }
    }
}
