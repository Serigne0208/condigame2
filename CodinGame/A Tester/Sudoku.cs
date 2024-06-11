using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    public class Sudoku
    {

        public static class SudokuChecker
        {
            public static bool SudokuCheck(List<List<int>> s)
            {
                // Vérification des lignes
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        if (s[row][col] == s[row][col + 1])
                        {
                            return false;
                        }
                    }
                }

                // Vérification des colonnes
                for (int col2 = 0; col2 < 9; col2++)
                {
                    for (int row2 = 0; row2 < 8; row2++)
                    {
                        if (s[row2][col2] == s[row2 + 1][col2])
                        {
                            return false;
                        }
                    }
                }

                // grid checker
                for (int row = 0; row < 9; row += 3)
                    for (int col = 0; col < 9; col += 3)
                        // row, col is start of the 3 by 3 grid
                        for (int pos = 0; pos < 8; pos++)
                            for (int pos2 = pos + 1; pos2 < 9; pos2++)
                                if (s[row + pos%3][col + pos/3]==s[row + pos2%3][col + pos2/3])
                                    return false;

                return true;
            }

            public static void Main()
            {
                List<List<int>> sudokuGrid = new List<List<int>> {
            new List<int> { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
            new List<int> { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
            new List<int> { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
            new List<int> { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
            new List<int> { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
            new List<int> { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
            new List<int> { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
            new List<int> { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
            new List<int> { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
        };

                bool isValid = SudokuCheck(sudokuGrid);
                Console.WriteLine("The Sudoku grid is " + (isValid ? "valid." : "invalid."));
            }
        }

    }
}
