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
            string Design = "";
            // there will be 9 possible mistakes
            if (WrongTries == 0)
            {
                Design = "safe :)";
            }
            else if (WrongTries == 1)
            {
                Design = " \n |\n |\n |\n |\n |\n |\n_|___";
            }
            else if (WrongTries == 2)
            {
                Design = "_________\n |\n |\n |\n |\n |\n |\n_|___";
            }
            else if (WrongTries == 3)
            {
                Design = "_________\n |/      |\n |\n |\n |\n |\n |\n_|___";
            }
            else if (WrongTries == 4)
            {
                Design = "_________\n |/      |\n |      (_)\n |\n |\n |\n |\n_|___";
            }
            else if (WrongTries == 5)
            {
                Design = "_________\n |/      |\n |      (_)\n |       |\n |       |\n |\n |\n_|___";
            }
            else if (WrongTries == 6)
            {
                Design = "_________\n |/      |\n |      (_)\n |      \\|\n |       |\n |\n |\n_|___";
            }
            else if (WrongTries == 7)
            {
                Design = "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |\n |\n_|___";
            }
            else if (WrongTries == 8)
            {
                Design = "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \n |\n_|___";
            }
            else
            {
                Design = "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \\\n |\n_|___";
            }
            return Design;
        }
    }
}
// full design = "_________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \\\n |\n_|___"
