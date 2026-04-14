using System;

namespace Snake2507cb1.Models
{
    public class Grid
    {
        public int Width = 30;
        public int Height = 20;
        public Food Food;

        public Grid()
        {
            Food = new Food(Width, Height);
        }

        public bool IsHitBorder(Snake snake)
        {
            return snake.Coordinats.X < 0 || snake.Coordinats.X >= Width ||
                   snake.Coordinats.Y < 0 || snake.Coordinats.Y >= Height;
        }

        public bool IsHitSelf(Snake snake)
        {
            for (int i = 0; i < snake.Body.Count; i++)
            {
                if (snake.Body[i].X == snake.Coordinats.X && snake.Body[i].Y == snake.Coordinats.Y)
                    return true;
            }
            return false;
        }

        public void Update(Snake snake)
        {
            snake.Move();
            if (snake.Coordinats.X == Food.Coordinats.X && snake.Coordinats.Y == Food.Coordinats.Y)
            {
                snake.Grow = true;
                snake.Score++; // Увеличиваем счётчик
                Food.Spawn(Width, Height);
            }
        }

        public void Render(Snake snake)
        {
            Console.Clear();
            Console.WriteLine($"Счёт: {snake.Score}");

            Console.Write(" ");
            for (int i = 0; i < Width + 2; i++) Console.Write("-");
            Console.WriteLine();

            for (int y = 0; y < Height; y++)
            {
                Console.Write("|");
                for (int x = 0; x < Width; x++)
                {
                    bool isHead = (x == snake.Coordinats.X && y == snake.Coordinats.Y);
                    bool isBody = false;
                    for (int i = 0; i < snake.Body.Count; i++)
                    {
                        if (snake.Body[i].X == x && snake.Body[i].Y == y) { isBody = true; break; }
                    }
                    bool isFood = (x == Food.Coordinats.X && y == Food.Coordinats.Y);

                    if (isHead) Console.Write("O");
                    else if (isBody) Console.Write("o");
                    else if (isFood) Console.Write("*");
                    else Console.Write(" "); // Прозрачное поле
                }
                Console.WriteLine("|");
            }

            Console.Write(" ");
            for (int i = 0; i < Width + 2; i++) Console.Write("-");
            Console.WriteLine();
        }
    }
}