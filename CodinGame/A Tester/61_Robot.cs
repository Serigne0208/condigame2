using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.A_Tester
{
    class _61_Robot
    {
		public static int w, h, iter = 0;


		public static int[] Solve(string direction, int x, int y, int width, int height)
		{
			int[] r = new int[2];

			if (iter == 0)
			{
				(r[0], r[1], w, h) = direction switch
				{
					"U" => (x, y / 2, 1, y),
					"UR" => ((width + x) / 2, y / 2, width - x, y),
					"R" => ((width + x) / 2, y, width - x, 1),
					"DR" => ((width + x) / 2, (height + y) / 2, width - x, height - y),
					"D" => (x, (height + y) / 2, 1, height - y),
					"DL" => (x / 2, (height + y) / 2, x, height - y),
					"L" => (x / 2, y, x, 1),
					"UL" => (x / 2, y / 2, x, y),
					_ => throw new Exception()
				};
			}
			else
			{
				(r[0], r[1], w, h) = direction switch
				{
					"U" => (x, y - h / 2, 1, h / 2),
					"UR" => (x + w / 2, y - h / 2, w / 2, h / 2),
					"R" => (x + w / 2, y, w / 2, 1),
					"DR" => (x + w / 2, y + h / 2, w / 2, h / 2),
					"D" => (x, y + h / 2, 1, h / 2),
					"DL" => (x - w / 2, y + h / 2, w / 2, h / 2),
					"L" => (x - w / 2, y, w / 2, 1),
					"UL" => (x - w / 2, y - h / 2, w / 2, h / 2),
					_ => throw new Exception()
				};
			}

			iter++;

			return r;
		}
	}
}
