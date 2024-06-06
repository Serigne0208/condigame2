using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.En_Cours
{
    class _64_Counter
    {
        private static int count = 0;

        ///Increments count in a thread-safe manner
        public static int Increment()
        {
            count = count + 1;
            return count;
        }
    }
}
