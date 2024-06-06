using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.Fini
{
    class _43_Filter
    {
        public IEnumerable<string> filter(List<string> String)
        {

            return String.Where(r => r.StartsWith("L")).OrderBy(c => c);

        }
    }
}
