using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hangman___OOP
{
    public class WordPuzzle

    {
        public Player player;
        public string chosenWord; // vybrané slovo - tajenka
        public string guessedWord; // pomocná proměnná - zobrazí hráčem uhádnutá a neuhádnutá písmena
        public int unguessedLetters; // počet doposud neuhádnutých písmen
        public int numberOfBadGuesses = 0; // počet špatných pokusů
        char[] GuessedWordArray;

        public WordPuzzle()
        {
            ChooseWordPuzzle();
            player = new Player();
        }

        public void ChooseWordPuzzle() // vybere tajenku ze seznamu slova představí hráči její délku
        {
            // seznam tajenek (zvířat) a jeho převedení na List
            string[] animals = new string[] { "elephant", "gorilla", "penguin", "tiger", "butterfly", "dolphin", "toad", "cobra", "rabbit", "pony", "lizard", "octopus", "salmon", "pigeon" };
            List<string> animalsList = new List<string>(animals);

            // náhodný výběr tajenky (zvířete)
            Random choiceOfAnimal = new Random();
            int animalsIndex = choiceOfAnimal.Next(0, animalsList.Count);
            chosenWord = animalsList[animalsIndex]; // tajenka

            unguessedLetters = chosenWord.Length; // počet písmen tajenky

            // vytvoření pomocné proměnné, která ukazuje uhádnutá a neuhádnutá písmena
            guessedWord = new string('_', chosenWord.Length);
            GuessedWordArray = guessedWord.ToCharArray();

            // informuje hráče, na kolik písmen je tajenka (zvíře)
            Console.WriteLine($"Guess the {chosenWord.Length}-letter animal!");
            Console.WriteLine(GuessedWordArray);
        }

        public void ReturnGuessedWord(Player player) // porovná znak zadaný od hráče se znaky v tajence
        {
            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == player.enteredLetter) // v případě, že se hráč trefil
                {
                    GuessedWordArray[i] = player.enteredLetter;
                    unguessedLetters -= 1;
                    numberOfBadGuesses -= 1; // počet špatných tahů se zde sice sníží o jeden, ale vynuluje se níže v rámci while cyklu
                }
            }
            numberOfBadGuesses += 1; // přičte počet špatných tahů
            Console.WriteLine(GuessedWordArray); // vypíše hráčem uhádnutá a neuhádnutá písmena
        }
    }
}
