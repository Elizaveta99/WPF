using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_03_2018
{
    class GameFridge
    {
        public int SIZE = 4;
        public bool[,] table { get; private set; }
        public GameFridge()
        {
            table = new bool[SIZE, SIZE];
            startGame();
        }
        public void startGame()
        {
            Random rnd = new Random();
            do
            {
                for (int i = 0; i < SIZE; i++)
                    for (int j = 0; j < SIZE; j++)
                        table[i, j] = (rnd.Next() % 2 == 0 /*& 1 == 0*/); // &
            } while (isOpen());
        }
        public bool isOpen()
        {
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (!table[i, j])
                        return false;
            return true;
        }

        public void replace(int r, int c)
        {
            for (int i = 0; i < SIZE; i++)
                table[i, c] = !table[i, c];
            for (int i = 0; i < SIZE; i++)
                table[r, i] = !table[r, i];
            table[r, c] = !table[r, c];
        }
    }
}
