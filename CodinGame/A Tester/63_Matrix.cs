using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.A_Tester
{
    class _63_Matrix
    {
		int[,] test = new int[,] { { 1, 1, 0, 1 }, { 1, 1, 0, 1 }, { 1, 1, 0, 1 }, { 1, 1, 0, 1 }, { 1, 1, 0, 1 } };

		public static int FindLargestSquare(int[,] M)
		{
			int L = M.GetLength(0);
			int C = M.GetLength(1);
			var check = new int[L, C, 2];

			int pl, pc;

			int temp = 0;

			for (int i = 0; i < L; i++)
			{
				for (int j = 0; j < C; j++)
				{
					pl = i; pc = j;

					if (j > 0 && M[i, j - 1] == 1)
					{
						check[i, j, 0] = M[i, j] * (check[i, j - 1, 0] - 1);
					}
					else
					{
						while (pc < C && M[i, pc] == 1)
						{
							pc++;
							temp++;
						}

						check[i, j, 0] = temp;
						temp = 0;
					}

					if (i > 0 && M[i - 1, j] == 1)
					{
						check[i, j, 1] = M[i, j] * (check[i - 1, j, 1] - 1);
					}
					else
					{
						while (pl < L && M[pl, j] == 1)
						{
							pl++;
							temp++;
						}

						check[i, j, 1] = temp;
						temp = 0;
					}
				}
			}

			int r = 0;

			for (int i = 0; i < L; i++)
			{
				for (int j = 0; j < C; j++)
				{
					int t = check[i, j, 0];

					for (int k = 0; k < check[i, j, 0]; k++)
					{
						if (j <= check[i, j + k, 1] && check[i, j + k, 1] < t) t = check[i, j + k, 1];
					}

					r = Math.Max(r, t);
				}
			}

			return r;
		}
	}
}
