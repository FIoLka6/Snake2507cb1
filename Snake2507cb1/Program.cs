using Snake2507cb1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Snake snake = new Snake();
        bool start = true;

        Console.WriteLine("Управление: W, A, S, D. Выход: 1");

        while (start)
        {
            // Ждем нажатия клавиши
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Переход на новую строку после нажатия

            switch (ch)
            {
                case 'w':
                    // Вверх (Y - 1)
                    snake.ChangeVector(new Vector(0, -1));
                    snake.Move();
                    Console.WriteLine(snake.ToString());
                    break;

                case 's':
                    // Вниз (Y + 1)
                    snake.ChangeVector(new Vector(0, 1));
                    snake.Move();
                    Console.WriteLine(snake.ToString());
                    break;

                case 'a':
                    // Влево (X - 1)
                    snake.ChangeVector(new Vector(-1, 0));
                    snake.Move();
                    Console.WriteLine(snake.ToString());
                    break;

                case 'd':
                    // Вправо (X + 1)
                    snake.ChangeVector(new Vector(1, 0));
                    snake.Move();
                    Console.WriteLine(snake.ToString());
                    break;

                case '1':
                    start = false;
                    break;

                default:
                    // Обработка неверного ввода
                    Console.WriteLine("Неверная команда! Используйте W, A, S, D или 1.");
                    break;
            }
        }
    }
}