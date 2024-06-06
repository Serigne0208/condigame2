using System;
using System.IO;
using System.Linq;

namespace CodinGame.A_Tester
{
	class _72_SmallestIntervall
	{
		public static int FindSmallestInterval(int[] numbers)
		{
			int mi = numbers.Min();
			int ma = numbers.Max();

			var bucket = new int[ma - mi + 1];

			foreach (int i in numbers) bucket[i - mi]++;

			int r = ma - mi;
			int count = ma - mi; //Je triche un peu pour ne pas avoir à commencer le parcours de mon tableau à la deuxième valeur.

			foreach (int i in bucket)
			{
				switch (i)
				{
					case 1:
						r = Math.Min(r, count);
						count = 1;
						break;
					case 0:
						count++;
						break;
					default:
						return 0;
				}
			}

			return r;
		}
	}
}