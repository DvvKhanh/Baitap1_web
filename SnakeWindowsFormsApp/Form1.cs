using System;
using System.Drawing;
using System.Windows.Forms;
using SnakeLib;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        SnakeGame game;
        Timer timer;
        int cellSize = 20;

        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
            this.Text = "Snake Game - WinForms";

            game = new SnakeGame(20, 20);
            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += UpdateGame;
            timer.Start();

            this.BackColor = Color.LightGreen;
            this.DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: game.Dir = Direction.Up; break;
                case Keys.Down: game.Dir = Direction.Down; break;
                case Keys.Left: game.Dir = Direction.Left; break;
                case Keys.Right: game.Dir = Direction.Right; break;
            }
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            game.Update();
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nếu chưa cần gì thì có thể để trống
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Vẽ snake
            foreach (Point p in game.Snake)
            {
                g.FillRectangle(Brushes.Green, p.X * cellSize, p.Y * cellSize, cellSize, cellSize);
            }

            // Vẽ food
            g.FillRectangle(Brushes.Black, game.Food.X * cellSize, game.Food.Y * cellSize, cellSize, cellSize);

            if (game.IsGameOver)
            {
                g.DrawString("Game Over!", new Font("Arial", 20), Brushes.Red, new PointF(100, 200));
            }
        }
    }
}
