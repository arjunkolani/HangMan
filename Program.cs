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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Sophie.OutputGallows(i));
            }
        }
    }
}
