using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.Fini
{
    class _40_Intervalle
    {
        static public int Calc(int[] array, int n1, int n2)
        {
            List<int> intervalle = new List<int>();

            for (int i = n1; i <= n2; i++)

                intervalle.Add(array[i]);

            return intervalle.Sum();
        }
    }
}
