using System;
using System.Collections.Generic;
using System.Drawing;

namespace SnakeLib
{
    public enum Direction { Up, Down, Left, Right }

    public class SnakeGame
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public List<Point> Snake { get; private set; }
        public Point Food { get; private set; }
        public Direction Dir { get; set; }
        public bool IsGameOver { get; private set; }
        private Random rand = new Random();

        public SnakeGame(int width, int height)
        {
            Width = width;
            Height = height;
            ResetGame();
        }

        public void ResetGame()
        {
            Snake = new List<Point> { new Point(Width / 2, Height / 2) };
            Dir = Direction.Right;
            SpawnFood();
            IsGameOver = false;
        }

        public void SpawnFood()
        {
            Food = new Point(rand.Next(0, Width), rand.Next(0, Height));
        }

        public void Update()
        {
            if (IsGameOver) return;

            Point head = Snake[0];
            Point newHead = head;

            switch (Dir)
            {
                case Direction.Up: newHead = new Point(head.X, head.Y - 1); break;
                case Direction.Down: newHead = new Point(head.X, head.Y + 1); break;
                case Direction.Left: newHead = new Point(head.X - 1, head.Y); break;
                case Direction.Right: newHead = new Point(head.X + 1, head.Y); break;
            }

            // Check collision
            if (newHead.X < 0 || newHead.Y < 0 || newHead.X >= Width || newHead.Y >= Height || Snake.Contains(newHead))
            {
                IsGameOver = true;
                return;
            }

            Snake.Insert(0, newHead);

            if (newHead == Food)
            {
                SpawnFood(); // ăn được mồi
            }
            else
            {
                Snake.RemoveAt(Snake.Count - 1); // xóa đuôi
            }
        }
    }
}
