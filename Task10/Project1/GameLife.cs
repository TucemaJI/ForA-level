using System;

namespace Project1
{
    class GameLife
    {
        char[,] _prevField = new char[9, 9];
        char[,] _field = new char[9, 9];
        public void FillField()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _field[i, j] = ' ';
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
            }
        }
        public void SetPoints()
        {
            _field[3, 1] = '+';
            _field[3, 2] = '+';
            _field[3, 0] = '+';
            //_field[2, 1] = '+';
            //_field[2, 2] = '+';
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Show()
        {
            for (int i = 0; i< 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(_field[i, j]);
                }
                Console.WriteLine();
            }
        }
        public int IsLive()
        {
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (_prevField[i, j] == '+')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void PointNeighbours(int[,] _mass, int x, int y)
        {
            int count = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i == x && j == y)
                    {
                        continue;
                    }
                    _mass[count, 0] = i;
                    _mass[count, 1] = j;
                    count++;
                }
            }
        }
        private int CountNeighbours(char[,] _field, int x, int y)
        {
            int coun = 0;
            int[,] _nb = new int[9, 2];
            int x1, y1;

            PointNeighbours(_nb, x, y);

            for (int i = 0; i < 9; i++)
            {
                x1 = _nb[i, 0];
                y1 = _nb[i, 1];

                if (x1 < 0 || y1 < 0)
                {
                    continue;
                }
                if (x1 >= 9 || y1 >= 9)
                {
                    continue;
                }

                if (_field[x1, y1] == '+')
                {
                    coun++;
                }

            }
            return coun;
        }
        public void Round()
        {
            int live_nb;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    live_nb = CountNeighbours(_prevField, i, j);

                    if (_prevField[i, j] != '+' && live_nb == 2)
                    {
                        _field[i, j] = '+';
                    }
                    else
                    {
                        _field[i, j] = ' ';
                    }
                }
            }
        }
        public void Copy()
        {
            for (int i = 0; i < 9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _prevField[i,j] = _field[i,j];
                }
            }
        }
        public bool Compare()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(_field[i, j] != _prevField[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
