using Snake2507cb1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Snake snake = new Snake();

        bool start = true;
        while (start)
        {
            // Ждём нажатие клавиши (блокирующий вызов)
            char ch = Console.ReadKey().KeyChar;

            switch (ch)
            {
                case 'w':
                    {
                        //изменить вектор на вверх
                        snake.ChangeVector(new Vector(0, -1));
                        //изменить координату
                        snake.Move();
                        Console.WriteLine(snake.ToString());
                        break;
                    }
                case 's':
                    {
                        //изменить вектор на вниз
                        snake.ChangeVector(new Vector(0, 1));
                        //изменить координату
                        snake.Move();
                        Console.WriteLine(snake.ToString());
                        break;
                    }

                case 'a':
                    {
                        //изменить вектор на влево
                        snake.ChangeVector(new Vector(-1, 0));
                        //изменить координату
                        snake.Move();
                        Console.WriteLine(snake.ToString());
                        break;
                    }

                case 'd':
                    {
                        //изменить вектор на вправо
                        snake.ChangeVector(new Vector(1, 0));
                        //изменить координату
                        snake.Move();
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
    }
}