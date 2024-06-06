using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    
    public class Solution
    {
        /* 
        * @param numbers un tableau d'entiers positifs.
        * @param k un entier.
        * @return un tableau contenant deux entiers représentant les indices de la paire d'entiers dont la somme est égale à k.
        */
        public static int[] FindSumPair(List<int> numbers, int k)
        {
            // Utiliser un dictionnaire pour stocker les nombres et leurs indices
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            // Parcourir la liste de nombres
            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                int complement = k - num;

                // Vérifier si le complément existe déjà dans le dictionnaire
                if (numDict.ContainsKey(complement))
                {
                    // Si oui, retourner les indices de la paire
                    return new int[] { numDict[complement], i };
                }

                // Sinon, ajouter le nombre actuel et son indice dans le dictionnaire
                if (!numDict.ContainsKey(num)) // Ajout pour éviter les doublons
                {
                    numDict[num] = i;
                }
            }

            // Si aucune paire n'a été trouvée, retourner un tableau vide
            return new int[0];
        }

        public static void Main(string[] args)
        {
            // Exemple de test
            List<int> numbers = new List<int> { 1, 5, 8, 1, 2 };
            int k = 13;
            int[] result = FindSumPair(numbers, k);
            Console.WriteLine(string.Join(", ", result)); // Devrait imprimer [1, 2] si une paire est trouvée
        }
    }

}
