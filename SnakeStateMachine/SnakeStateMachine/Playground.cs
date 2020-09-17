using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeStateMachine
{
    public class Playground
    {

        private static int _playgroundheigt = 19;
        private static int _playgroundwidth = 38;
        private char[,] _playground = new char[_playgroundheigt, _playgroundwidth];
        private int[] _snake = new int[2];
 
        public Playground(int height, int width)
        {
            _playgroundheigt = height;
            _playgroundwidth = width;
        }

        public Playground()
        {
            resetpos();
        }

        private void resetpos()
        {
            _snake[0] = (_playgroundheigt / 2);
            _snake[1] = (_playgroundwidth / 2);
        }

        public void DrawPlayground()
        {
            
            for (int i = 0; i < _playground.GetLength(0); i++)
            {
                for (int j = 0; j < _playground.GetLength(1); j++)
                {
                    Console.Write(_playground[i,j]);
                }
                Console.WriteLine();
            }
        }

        public void Assignchar(SnakeStateMachine._directionEnum direction)
        {
            

            _playground = new char[_playgroundheigt, _playgroundwidth];

            if (direction == SnakeStateMachine._directionEnum.North)
            {
                _snake[0] = _snake[0] - 1;
            }
            if (direction == SnakeStateMachine._directionEnum.South)
            {
                _snake[0] = _snake[0] + 1;
            }
            if (direction == SnakeStateMachine._directionEnum.West)
            {
                _snake[1] = _snake[1] - 1;
            }
            if (direction == SnakeStateMachine._directionEnum.East)
            {
                _snake[1] = _snake[1] + 1;
            }

            if (_snake[0] == 0 || _snake[0] == _playgroundheigt -1  || _snake[1] == 0 || _snake[1] == _playgroundwidth - 1)
            {
                Console.WriteLine("du død");
                resetpos();
            }
            else
            {
                Console.Clear();

                for (int i = 0; i < _playground.GetLength(0); i++)
                {
                    _playground[i, 0] = 'X';
                    _playground[i, _playground.GetLength(1) - 1] = 'X';
                    for (int j = 0; j < _playground.GetLength(1); j++)
                    {
                        _playground[0, j] = 'X';
                        _playground[_playground.GetLength(0) - 1, j] = 'X';

                        _playground[_snake[0], _snake[1]] = 'O';
                    }
                }



                Console.Write(_snake[0]);
                Console.WriteLine(_snake[1]);
            }
            

        }
    }
}
