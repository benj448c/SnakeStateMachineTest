using System;

namespace SnakeStateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            worker worker1 = new worker();
            worker1.Start();
        }
    }
}
