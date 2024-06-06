using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    public class TailleDisque
    {
        static void Main(string[] args)
        {
            // Lecture des entrées
            Console.WriteLine("Entrez la taille du cluster :");
            int tailleCluster = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la taille du fichier :");
            int tailleFichier = int.Parse(Console.ReadLine());

            // Calcul de la taille sur le disque
            int tailleDisque = CalculerTailleSurDisque(tailleFichier, tailleCluster);

            // Affichage du résultat
            Console.WriteLine(tailleDisque);
        }

        static int CalculerTailleSurDisque(int tailleFichier, int tailleCluster)
        {
            // Calculer le nombre de clusters nécessaires
            int nombreClusters = (tailleFichier + tailleCluster - 1) / tailleCluster;

            // Calculer la taille sur le disque
            int tailleSurDisque = nombreClusters * tailleCluster;

            return tailleSurDisque;
        }

    }
}
