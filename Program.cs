using System;
using System.Numerics;

namespace HangMan
{
    internal class Program
    {
        // This bit creates all the variables that are used throughout
        static string secretWord;
        static char[] guessedWord;
        static List<char> guessedLetters = new List<char>();
        static int maxGuesses = 9;
        static int remainingGuesses = maxGuesses;
        static int difficulty = 0;

        static void Main(string[] args)
        {
            // Choose a difficulty --> chooses the secretword
            Console.WriteLine("Choose a number between 0 and 2 for your difficulty: ");
            string temp = Console.ReadLine();

            // Minimises breakages by catching the error of the input not being an integer
            try
            {
                difficulty = Int32.Parse(temp);
            }
            catch (FormatException e)
            {
                difficulty = 100;
                Console.WriteLine("Stop trying to put characters in you DOUGHNUT!!!");
            }

            // This minimises breakages by setting the difficulty to 2 if the input is greater than 2
            // Also follows on from the try-break bit where if the error is found, the difficulty is set to 100 which is >2
            if (difficulty > 2 || difficulty < 0)
            {
                difficulty = 2;
                Console.WriteLine("Good try breaking the system Mr Tattam. Now face our hardest level");
                Console.WriteLine("(Insert evil laugh here)");
            }
            secretWord = PickWord(difficulty);

            Console.WriteLine("Welcome to Hangman!");

            // creates a string of underscores with the length of the secret word
            guessedWord = new char[secretWord.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            // This bit is the main text that is shown after every guess
            while (remainingGuesses > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Secret Word: " + new string(guessedWord));
                Console.WriteLine("Guessed Letters: " + string.Join(", ", guessedLetters));
                Console.WriteLine("Remaining Guesses: " + remainingGuesses);
                Console.Write("Enter a letter to guess: ");
                // The next line basically minimises the user input.
                // It takes in ONE CHARACTER which minimises user error
                char guess = Char.ToLower(Console.ReadKey().KeyChar);

                // This also minimises breakages as it will not accept keys that are not chars
                if (!char.IsLetter(guess))
                {
                    Console.WriteLine("\nPlease enter a valid letter.");
                    continue;
                }

                // Again, minimises error by preventing repeated guesses
                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("\nYou've already guessed that letter.");
                    continue;
                }

                guessedLetters.Add(guess);

                // This replaces the underscore with the guessed letter 
                if (secretWord.Contains(guess))
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord[i] == guess)
                        {
                            guessedWord[i] = guess;
                        }
                    }

                    //End of the game:

                    if (new string(guessedWord) == secretWord)
                    {
                        Console.WriteLine("\nCongratulations! You guessed the word: " + secretWord);
                        break;
                    }
                }
                else
                {
                    //This will increment the gallows system and repeat the whole chunk of code above
                    remainingGuesses--;
                    Console.WriteLine("\nIncorrect guess. Try again.");
                    int Errors = maxGuesses - remainingGuesses;
                    Console.WriteLine(Sophie.OutputGallows(Errors));
                    //This function displays the gallows - sophie
                }
            }

            if (remainingGuesses == 0)
            {
                Console.WriteLine("\nYou're out of guesses! The word was: " + secretWord);
            }

            Console.WriteLine("Game Over.");
        }

        //Arjun's function takes in the difficulty and chooses a word from the txt files
        public static string PickWord(int difficulty)
        {
            string[] fileNames = { "Easy", "Medium", "Hard" };
            string fileName = "../../../" + fileNames[difficulty] + ".txt";

            string[] wordBase = File.ReadAllLines(fileName);

            Random rd = new Random();

            int wordIndex = rd.Next(0, wordBase.Length - 1);
            return wordBase[wordIndex];
        }
    }
}
