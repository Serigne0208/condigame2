using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    public class sudoku1
    {


        public class Solution
        {

            /**
            * @param sudoku Un tableau en deux dimensions contenant des chiffres de 1 à 9.
            * @return Un entier. 1 si la grille de sudoku est correcte. 0 sinon.
            */
            public static int CheckSudoku(List<List<int>> sudoku)
            {
                // Helper function to check if a list contains all digits from 1 to 9 exactly once
                bool ContainsAllDigitsOnce(List<int> list)
                {
                    return list.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9));
                }

                // Check all rows
                for (int row = 0; row < 9; row++)
                {
                    if (!ContainsAllDigitsOnce(sudoku[row]))
                    {
                        return 0;
                    }
                }

                // Check all columns
                for (int col = 0; col < 9; col++)
                {
                    List<int> column = new List<int>();
                    for (int row = 0; row < 9; row++)
                    {
                        column.Add(sudoku[row][col]);
                    }
                    if (!ContainsAllDigitsOnce(column))
                    {
                        return 0;
                    }
                }

                // Check all 3x3 regions
                for (int row = 0; row < 9; row += 3)
                {
                    for (int col = 0; col < 9; col += 3)
                    {
                        List<int> region = new List<int>();
                        for (int r = 0; r < 3; r++)
                        {
                            for (int c = 0; c < 3; c++)
                            {
                                region.Add(sudoku[row + r][col + c]);
                            }
                        }
                        if (!ContainsAllDigitsOnce(region))
                        {
                            return 0;
                        }
                    }
                }

                return 1; // If all checks pass, return 1 indicating the Sudoku is valid
            }

            /* Ignore and do not change the code below */

            /**
            * Try a solution
            * @param isCorrect Un entier. 1 si la grille de sudoku est correcte. 0 sinon.
            */
            private static void TrySolution(int isCorrect)
            {
                Console.WriteLine("" + JsonSerializer.Serialize(isCorrect));
            }

            public static void Main(string[] args)
            {
                TrySolution(CheckSudoku(
                    JsonSerializer.Deserialize<List<List<int>>>(Console.ReadLine())
                ));
            }
        }

    }
}
