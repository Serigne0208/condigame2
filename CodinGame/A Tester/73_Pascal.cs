using System;
using System.IO;
using System.Numerics;

namespace CodinGame.A_Tester
{
	class _73_Pascal
	{
		public static string Get(int l, int c)
		{
			decimal r = 1;

			c = Math.Min(c, l - c);

			for (int i = 1; i <= c; i++) r = r * (l - i + 1) / i;

			return r.ToString();
		}
	}
}