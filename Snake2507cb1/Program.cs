using Snake2507cb1.Models;
using System;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Snake snake = new Snake();
        Grid grid = new Grid();
        bool start = true;
        while (start)
        {
            // Неблокирующий ввод для зацикленного движения
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey(true);
                char ch = keyInfo.KeyChar;

                // Поддержка стрелок (маппим на WASD для сохранения логики switch)
                if (keyInfo.Key == ConsoleKey.UpArrow) ch = 'w';
                if (keyInfo.Key == ConsoleKey.DownArrow) ch = 's';
                if (keyInfo.Key == ConsoleKey.LeftArrow) ch = 'a';
                if (keyInfo.Key == ConsoleKey.RightArrow) ch = 'd';

                switch (ch)
                {
                    case 'w':
                        {
                            //изменить вектор
                            snake.Vector.SetDirection(ch);
                            //изменить коородинату
                            Console.WriteLine(snake.ToString());
                            break;
                        }
                    case 's':
                        {
                            //изменить вектор
                            snake.Vector.SetDirection(ch);
                            //изменить коородинату
                            Console.WriteLine(snake.ToString());
                            break;
                        }

                    case 'a':
                        {
                            //изменить вектор
                            snake.Vector.SetDirection(ch);
                            //изменить коородинату
                            Console.WriteLine(snake.ToString());
                            break;
                        }

                    case 'd':
                        {
                            //изменить вектор
                            snake.Vector.SetDirection(ch);
                            //изменить коородинату
                            Console.WriteLine(snake.ToString());
                            break;
                        }

                    case '1':
                        {
                            start = false;
                            break;
                        }
                }
            }

            // Автоматическое обновление и отрисовка каждый тик
            grid.Update(snake);
            grid.Render(snake);

            // Проверка столкновения с границей или своим телом
            if (grid.IsHitBorder(snake) || grid.IsHitSelf(snake))
            {
                Console.SetCursorPosition(0, grid.Height + 4);
                Console.WriteLine("Game Over! Столкновение с границей или телом.");
                Console.WriteLine($"Итоговый счёт: {snake.Score}");
                Console.ReadKey();
                start = false;
            }

            // Увеличение скорости при росте счёта (базовая задержка 150мс, минимум 60мс)
            int delay = Math.Max(60, 150 - snake.Score * 3);
            Thread.Sleep(delay);
        }
        Console.ReadKey();
    }
}