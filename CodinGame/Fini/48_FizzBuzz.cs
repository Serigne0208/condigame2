using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.Fini
{
    class _48_FizzBuzz
    {
        public static String FizzBuzz(int number, Dictionary<int, string> map)
        {
            string r = null;

            foreach (var d in map)
                if (number % d.Key == 0)
                    r += d.Value;

            return r ?? number.ToString();

        }
    }
}
