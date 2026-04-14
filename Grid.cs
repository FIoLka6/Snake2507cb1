using System;

namespace Snake2507cb1.Models
{
    public class Grid
    {
        public int Width { get; set; } = 30;
        public int Height { get; set; } = 20;
        public Coordinats Food { get; private set; }
        private Random random = new Random();

        public Grid()
        {
            SpawnFood();
        }

        public void SpawnFood()
        {
            Food = new Coordinats((short)random.Next(Width), (short)random.Next(Height));
        }

        public void MoveSnake(Snake snake)
        {
            snake.Move();

            // Обработка выхода за границы (зацикливание поля)
            if (snake.Coordinats.X >= Width) snake.Coordinats.X = 0;
            else if (snake.Coordinats.X < 0) snake.Coordinats.X = (short)(Width - 1);

            if (snake.Coordinats.Y >= Height) snake.Coordinats.Y = 0;
            else if (snake.Coordinats.Y < 0) snake.Coordinats.Y = (short)(Height - 1);

            // Проверка поедания еды
            if (snake.Coordinats.X == Food.X && snake.Coordinats.Y == Food.Y)
            {
                SpawnFood();
                // Здесь в будущем можно добавить логику увеличения хвоста змейки
            }
        }

        public void Render(Snake snake)
        {
            Console.Clear();
            Console.WriteLine($"Поле: {Width}x{Height} | Еда: {Food}");
            Console.WriteLine("Управление: W A S D | Выход: 1");
            Console.WriteLine(new string('-', Width));

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (x == snake.Coordinats.X && y == snake.Coordinats.Y)
                        Console.Write("@");
                    else if (x == Food.X && y == Food.Y)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', Width));
        }
    }
}