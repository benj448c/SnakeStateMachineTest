using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeStateMachine
{
    public class worker
    {
        private SnakeStateMachine snake;
        private Playground pg;
        public void Start()
        {
            snake = new SnakeStateMachine();
            pg = new Playground();
            Task.Run((() => { moving(); }));
            while (true)
            {
                Thread.Sleep(500);
                Playgroundworker();
            }
            
        }

        private void moving()
        {
            while (true)
            { 
                snake.changedirection(Console.ReadKey(true));
                Console.WriteLine(snake.DirectionName);   
            }

        }

        private void Playgroundworker()
        {
            pg.Assignchar(snake.DirectionName);
            pg.DrawPlayground();
        }

    }
}
