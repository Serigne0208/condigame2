using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodinGame.Fini
{
    class _46_IsTwin
    {
        public static bool isTwin(String a, String b)
        {
            return Enumerable.SequenceEqual(a.ToLower().ToList().OrderBy(_ => _), b.ToLower().ToList().OrderBy(_ => _));
        }
    }
}
