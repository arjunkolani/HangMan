using System;

namespace HangMan
{
    internal class CheckLetterFunction
    {
        public static List<int> CheckLetter(string secretWord, string guessedLetter)
        {
            
            List<int> instances = new List<int>(); 
            char guessedChar = Convert.ToChar(guessedLetter); 
            for (int i = 0; i<secretWord.Length; i++) 
            { 
                if (secretWord[i] == guessedChar) 
                { 
                    instances.Add(i);
                }
            } 
            return instances;
        }
    }
}
