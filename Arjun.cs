using System;
using System.IO;


namespace HangMan
{
    internal class Arjun
    {
        public static string pickWord(int difficulty)
        {
            string[] fileNames = { "Easy", "Medium", "Hard" };
            string fileName = "../../../" + fileNames[difficulty] + ".txt";

            string[] wordBase = File.ReadAllLines(fileName);

            Random rd = new Random();

            int wordIndex = rd.Next(0, wordBase.Length - 1);
            return wordBase[wordIndex];
        }
        
        public static void outputGuessed(string word, char[] guessedLetters)
        {
            string output = "";
            foreach (char letter in word)
            {
                bool guessed = false;
                foreach (char c in guessedLetters)
                {
                    if (c == letter)
                    {
                        guessed = true;
                        break;
                    }
                }

                if (guessed)
                {
                    output += letter;
                }
                else
                {
                    output += "_";
                }

                output += " ";
            }

            output = output.Trim();
            Console.WriteLine(output);
        }
    }
}
