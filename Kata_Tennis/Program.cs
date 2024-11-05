namespace Kata_Tennis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("GAME " + i);
                Console.WriteLine("------------------");
                TennisGame game = new TennisGame("Player1", "Player2");
                Console.WriteLine(game.PrintScore());
                while (!game.GameOver())
                {
                    if (random.Next(0, 2) == 0)
                    {
                        game.Player1Scored();
                        Console.WriteLine("##### Player 1 scores");
                    }
                    else
                    {
                        game.Player2Scored();
                        Console.WriteLine("##### Player 2 scores");
                    }
                    Console.WriteLine(game.PrintScore());
                }
            }
        }
    }
}
