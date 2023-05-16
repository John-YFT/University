using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_I_5
{
    internal class Array
    {
        private int[][] mass { get; set; }
        private int n { get; set; }
        private int m { get; set; }
        public Array(int n, int m)
        {
            this.n = n;
            this.m = m;
            this.mass = new int[this.n][];
            for (int i = 0;  i<this.n; i++)
            {
                this.mass[i] = new int[this.m];
            }
        }

        public void zapRand(int nach, int kon )
        {
            Random rnd = new Random();
            for (int i = 0; i <= 1; i++)
                for (int j = 0; j <= 2; j++)
                    mass[i][j] = rnd.Next(nach, kon);
        }
        public void zapMas(int i, int j, int znach)
        {
            mass[i][j] = znach;
        }
        public int Mass(int i, int j)
        {
            return mass[i][j];
        }
    }
}
