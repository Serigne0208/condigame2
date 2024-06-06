using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodinGame.A_Tester
{
    class _55_StoneMagic
    {
        public static int Magic(List<int> stones)
        {
           
            while (stones.GroupBy(i => i).Any(i => i.Count() > 1))
            {
                var key = stones.GroupBy(i => i).OrderByDescending(i => i.Count()).First().Key;
                stones.Remove(key);
                stones.Remove(key);
                stones.Add(key + 1);
            }

            return stones.Count();

        }
    }
}
