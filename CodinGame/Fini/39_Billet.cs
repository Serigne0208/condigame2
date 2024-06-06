using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.Fini
{
    class Change
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;
    }
    class _39_Billet
    {
        public static Change OptimalChange(long s)
        {
            Change change = new Change();

            if ((s == 1) || (s == 3))
            {
                return null;
            }

            if (s % 2 == 1)
            {
                change.bill5 = 1;
                s -= 5;
            }

            change.bill10 = s / 10;
            change.coin2 = (s % 10) / 2;

            return change;
        }
    }
}
