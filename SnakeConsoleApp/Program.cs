using System;
using System.Threading;
using SnakeLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            SnakeGame game = new SnakeGame(20, 10);
            ConsoleKey key = ConsoleKey.RightArrow;

            while (!game.IsGameOver)
            {
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow: game.Dir = Direction.Up; break;
                        case ConsoleKey.DownArrow: game.Dir = Direction.Down; break;
                        case ConsoleKey.LeftArrow: game.Dir = Direction.Left; break;
                        case ConsoleKey.RightArrow: game.Dir = Direction.Right; break;
                    }
                }

                game.Update();
                Draw(game);
                Thread.Sleep(200);
            }

            Console.SetCursorPosition(0, game.Height + 2);
            Console.WriteLine("Game Over! Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        static void Draw(SnakeGame game)
        {
            Console.Clear();
            for (int y = 0; y < game.Height; y++)
            {
                for (int x = 0; x < game.Width; x++)
                {
                    if (game.Snake.Contains(new System.Drawing.Point(x, y)))
                        Console.Write("O");
                    else if (game.Food.X == x && game.Food.Y == y)
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
