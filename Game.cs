using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hangman___OOP
{
    public class Game
    {
        public WordPuzzle wordPuzzle;
        public Player player;

        public Game()
        {
            wordPuzzle = new WordPuzzle();
            player = new Player();
        }

        public void StartGame() // hra probíhá, dokud hráč neuhodne všechna písmena, nebo dokud nevyčerpá všech 9 pokusů
        {
            while (wordPuzzle.unguessedLetters > 0 && wordPuzzle.numberOfBadGuesses < 9)
            {
                player.EnterLetter();
                wordPuzzle.ReturnGuessedWord(player);
            }
        }

        public void WonOrLost() // po skončení hry je vyhodnoceno, zda hráč tajenku uhodl nebo ne
        {
            if (wordPuzzle.unguessedLetters > 0) // pokud hráč tajenku neuhodl
            {
                Console.WriteLine($"Sorry, you didn't guess {wordPuzzle.chosenWord}!");
            }
            else // pokud hráč tajenku uhodl
            {
                Console.WriteLine($"Congratulations, you guessed {wordPuzzle.chosenWord}!");
            }
        }
    }
}
