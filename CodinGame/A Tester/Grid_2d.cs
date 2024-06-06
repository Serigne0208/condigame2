using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    public class Grid_2d
    {
        public static int[,] Solve(int[,] grid, List<Tuple<int, int>> rules)
        {
            // Construire un dictionnaire de règles pour une recherche rapide
            Dictionary<int, int> rulesDict = new Dictionary<int, int>();
            foreach (var rule in rules)
            {
                rulesDict[rule.Item1] = rule.Item2;
            }

            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            int[,] transmutedGrid = new int[rows, cols];

            // Appliquer les règles de transmutation à chaque élément de la grille
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int element = grid[i, j];
                    if (rulesDict.TryGetValue(element, out int transmutedElement))
                    {
                        transmutedGrid[i, j] = transmutedElement;
                    }
                    else
                    {
                        transmutedGrid[i, j] = element;
                    }
                }
            }

            return transmutedGrid;
        }

        public static void Main(string[] args)
        {
            int[,] grid = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            List<Tuple<int, int>> rules = new List<Tuple<int, int>>
        {
            Tuple.Create(1, 10),
            Tuple.Create(2, 20),
            Tuple.Create(3, 30),
            Tuple.Create(4, 40),
            Tuple.Create(5, 50)
        };

            int[,] transmutedGrid = Solve(grid, rules);

            // Afficher la grille transmutée
            for (int i = 0; i < transmutedGrid.GetLength(0); i++)
            {
                for (int j = 0; j < transmutedGrid.GetLength(1); j++)
                {
                    Console.Write(transmutedGrid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
