using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeStateMachine
{
    public class worker
    {
        public void Start()
        {
            moving();
        }

        private void moving()
        {
            SnakeStateMachine snake = new SnakeStateMachine();
            Console.WriteLine(snake.DirectionName);
            while (true)
            {
                snake.changedirection(Console.ReadKey(true));
                Console.WriteLine(snake.DirectionName);
            }
        }

    }
}
