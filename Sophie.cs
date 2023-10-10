using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class Sophie
    {

        public static string OutputGallows(int WrongTries)
        {
            string[] Design = new string[10] { "safe :)", " \n |\n |\n |\n |\n |\n |\n_|___", "_________\n |\n |\n |\n |\n |\n |\n_|___", "_________\n |/      |\n |\n |\n |\n |\n |\n_|___", "_________\n |/      |\n |      (_)\n |\n |\n |\n |\n_|___", "_________\n |/      |\n |      (_)\n |       |\n |       |\n |\n |\n_|___", "_________\n |/      |\n |      (_)\n |      \\|\n |       |\n |\n |\n_|___", "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |\n |\n_|___", "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \n |\n_|___", "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \\\n |\n_|___" };
            // there will be 9 possible mistakes
            return Design[WrongTries];
        }

        public static string DisplayGuesses(string word, string letters)
        {
            string OutStr = "";
            foreach (char c1 in word)
            {
                int check = 0;
                foreach (char c2 in letters)
                {
                    if (c1 == c2)
                    {
                        check++;
                    }
                }
                if (check == 1)
                {
                    OutStr += c1;
                }
                else
                {
                    OutStr += '_';
                }
            }
            return OutStr;
        }
        public static string Initial(string word)
        {
            string OutStr = "";
            foreach (char c1 in word)
            {
                OutStr += '_';
            }
            return OutStr;
        }
    }
}
