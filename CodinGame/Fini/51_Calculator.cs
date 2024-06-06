using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.Fini
{
    class _51_Calculator
    {
		public static string Sum(params string[] numbers)
		{
			decimal total = 0;

			foreach (string number in numbers)
			{
				total = total + decimal.Parse(number);
			}
			return total.ToString();
		}
	}
}
