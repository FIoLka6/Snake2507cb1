using Snake2507cb1.Models;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Snake snake = new Snake();
        Grid grid = new Grid();
        bool start = true;
        while (start)
        {
            grid.Render(snake);
            char ch = Console.ReadKey().KeyChar;

            switch (ch)
            {
                case 'w':
                    {
                        //изменить вектор
                        snake.Vector.SetDirection(ch);
                        //изменить коородинату
                        grid.MoveSnake(snake);
                        Console.WriteLine(snake.ToString());
                        break;
                    }
                case 's':
                    {
                        //изменить вектор
                        snake.Vector.SetDirection(ch);
                        //изменить коородинату
                        grid.MoveSnake(snake);
                        Console.WriteLine(snake.ToString());
                        break;
                    }

                case 'a':
                    {
                        //изменить вектор
                        snake.Vector.SetDirection(ch);
                        //изменить коородинату
                        grid.MoveSnake(snake);
                        Console.WriteLine(snake.ToString());
                        break;
                    }

                case 'd':
                    {
                        //изменить вектор
                        snake.Vector.SetDirection(ch);
                        //изменить коородинату
                        grid.MoveSnake(snake);
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
