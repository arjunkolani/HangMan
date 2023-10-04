using System;

namespace HangMan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word = Arjun.pickWord(2);
            Console.WriteLine(word);
            Console.WriteLine("Hello, World!");

            // temporary for the gallows function - sophie
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Sophie.OutputGallows(i));
            }

            // temporary for the outputting guessed letters + dashes func - sophie
            char[] letters = new char[] { 'a', 'b', 'c' };
            Console.WriteLine(Sophie.DisplayGuesses("absjdighd", letters));
            // length of array not defined (yet?)

            Console.WriteLine("Press Enter to close window...");
            Console.ReadLine();
        }
        
    }
}
