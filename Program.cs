namespace Hangman___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            game.WonOrLost();
        }
    }
}