using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.A_Tester
{
    class _58_ClosesToZero
    {
        public static int ClosestToZero(int[] ints)
        {

            if (ints.Length == 0) return 0;
            var closest = ints[0];
            foreach (int d in ints)
            {
                double abs = Math.Abs(d);
                double absClosest = Math.Abs(closest);
                if (abs < absClosest)
                {
                    closest = d;
                }
                else if (abs == absClosest && closest < 0)
                {
                    closest = d;
                }
            }

            return closest;
        }
    }
}
