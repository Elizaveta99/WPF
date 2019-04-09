using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Timers;


namespace game_15
{
    class Game15
    {
        private int n = 16;
        public int SIZE = 4; 
        public int[,] table { private set; get; }
        public int[,] table_save { private set; get; }
        public Game15()
        {
            table = new int[SIZE, SIZE];
            table_save = new int[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)  
                    table[i, j] = 0;
        }

        public int[] startGame()
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = i;
            genPermutations(ref a);
            int k = 0;
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                {
                    table[i, j] = a[k];
                    k++;
                }
            Save_game();
            return a;
        }

        public void genPermutations(ref int[] a)
        {
            for (int i = n - 1; i > -1; i--)
            {
                Random rnd = new Random();
                int j = rnd.Next(i + 1);
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                Thread.Sleep(20); 
            }
        }

        public bool no_desicion(int[] a)
        {
            int inv = 0, n_zero = -1;
            for (int i = 0; i < n; i++)
                if (a[i] != 0)
                {
                    for (int j = 0; j < i; j++)
                        if (a[j] > a[i])
                            inv++;
                }
                else n_zero = i;
            inv += n_zero / 4 + 1;
            return inv % 2 != 0;
        }

        public void change(int a, int b, int c, int d)
        {
            table[a, b] = table[c, d];
            table[c, d] = 0;
        }

        public void Save_game()
        {
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    table_save[i, j] = table[i, j];
        }

        public int[] Read()
        {
            int[] a = new int[n];
            int k = 0;
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                {
                    table[i, j] = table_save[i, j];
                    a[k++] = table[i, j];
                }
            return a;           
        }
    }
}
