using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //Отрисовка рамочки
            horixontal upLine = new horixontal(0, 78, 0, '+');
            horixontal downLine = new horixontal(0, 78, 24, '+');
            vertical leftLine = new vertical(0, 24, 0, '+');
            vertical rightLine = new vertical(0, 24, 78, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисовка точек

            
            point p = new point(4, 5, '*');
            snake Snake = new snake( p, 4, direction.RIGHT);
            Snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            point food = foodCreator.CreatFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreatFood();
                    food.Draw();

                }
                else
                {
                    snake.Move();
                }

            }
            Thread.Sleep(100);

          
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.HandleKey(key.Key);

                }



                Thread.Sleep(100);
                snake.Move();
                Console.ReadLine();
        }
    }
}

