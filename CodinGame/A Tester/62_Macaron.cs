using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.A_Tester
{
    class _62_Macaron
    {
        public static int ComputeTotalPrice(float unitPrice, string[] macarrons)
        {
            List<string> LstMacaron_Distinct = macarrons.Distinct().ToList();
            int prix = (int)unitPrice * macarrons.Count();


            switch (LstMacaron_Distinct.Count())
            {
                case 1: //Pas de réduction
                    return prix;

                case 2: // Réduction de 10%                 

                    return (int)Math.Ceiling((double)prix * (100 - 10) / 100);

                case 3: // Réduction de 20%
                    return (int)Math.Ceiling((double)prix * (100 - 20) / 100);

                case 4: // Réduction de 30%
                    return (int)Math.Ceiling((double)prix * (100 - 30) / 100);

                case 5: // Réduction de 40%
                    return (int)Math.Ceiling((double)prix * (100 - 40) / 100);


            }
            return 0;
        }
    }
}

