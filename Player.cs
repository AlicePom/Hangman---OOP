using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman___OOP
{
    public class Player
    {
        public WordPuzzle wordPuzzle;
        public char enteredLetter;

        public Player()
        {   
        }

        public char EnterLetter() // načte písmeno zadané hráčem
        {
            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine();
            enteredLetter = input.KeyChar;
            return enteredLetter;
        }
    }
}
