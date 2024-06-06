using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    public class CountValidPath
    {
        public static int CountPaths(List<int> shops, List<List<int>> roads)
        {
            int n = shops.Count;

            // Création de la liste d'adjacence pour le graphe
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            foreach (var road in roads)
            {
                int u = road[0];
                int v = road[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }

            // Trouver tous les indices pour chaque type de magasin
            List<int>[] shopTypes = new List<int>[4];
            for (int i = 0; i < 4; i++)
            {
                shopTypes[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                shopTypes[shops[i]].Add(i);
            }

            int pathCount = 0;

            // Fonction auxiliaire pour effectuer le DFS
            void DFS(int current, bool[] visited, int typeMask)
            {
                if (typeMask == 15)
                { // Tous les quatre types (0b1111 = 15) ont été visités
                    pathCount++;
                    return;
                }

                foreach (var neighbor in graph[current])
                {
                    if (!visited[neighbor])
                    {
                        int nextType = shops[neighbor];
                        int nextMask = typeMask | (1 << nextType);
                        if (nextMask != typeMask)
                        { // Ne procéder que si ce type de magasin n'a pas été visité dans ce chemin
                            visited[neighbor] = true;
                            DFS(neighbor, visited, nextMask);
                            visited[neighbor] = false;
                        }
                    }
                }
            }

            // Essayer de commencer par chaque magasin de chaque type
            for (int type = 0; type < 4; type++)
            {
                foreach (var start in shopTypes[type])
                {
                    bool[] visited = new bool[n];
                    visited[start] = true;
                    DFS(start, visited, 1 << type);
                }
            }

            return pathCount;
        }

        public static void Main(string[] args)
        {
            List<int> shops = System.Text.Json.JsonSerializer.Deserialize<List<int>>(Console.ReadLine());
            List<List<int>> roads = System.Text.Json.JsonSerializer.Deserialize<List<List<int>>>(Console.ReadLine());
            Console.WriteLine(CountPaths(shops, roads));
        }


    }
}
