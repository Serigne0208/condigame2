using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.Fini
{
    class _41_Nouvelle_Danse
    {
        public static int GetPositionAt(int n)
        {
            int[] deplacement = new int[3];
            List<int> valeur = new List<int>();

            //étape 0
            int danse = 0; //position
            valeur.Add(danse);

            //étape 1           
            danse += 1;
            deplacement[0] = danse;
            valeur.Add(danse);

            //étape 2           
            danse += -2;
            deplacement[1] = -2;
            valeur.Add(danse);

            for (int i = 0; i < 4; i++)
            {
                deplacement[2] = deplacement[1] - deplacement[0];

                deplacement[0] = deplacement[1];
                deplacement[1] = deplacement[2];

                valeur.Add(danse += deplacement[2]);
            }

            return valeur[n % 6];
        }
    }
}
