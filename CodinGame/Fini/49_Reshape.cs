using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.Fini
{
    class _49_Reshape
    {
		public static string reshape(int n, string str)
		{
            str = str.Replace(" ", "");
            string chaineF = "";
            int coupe = 0;
            for (int i = 0; i < str.Length / n; i++)
            {
                chaineF = string.Concat(chaineF, str.Substring(coupe, n), "\n");
                coupe += n;
            }
            if (str.Length % n != 0)
            {
                chaineF = string.Concat(chaineF, str.Substring(coupe, str.Length % n));
            }
            else if(chaineF.EndsWith("n"))
            {
                chaineF = chaineF[0..^2];
            }
            return chaineF;
        }
	}
}
