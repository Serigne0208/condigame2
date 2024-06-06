using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.A_Tester
{
    class _59_SansDoublons
    {
        public static int[] FilterDuplicate(int[] data)
        {

            return data.Distinct().ToArray();
        }
    }
}
