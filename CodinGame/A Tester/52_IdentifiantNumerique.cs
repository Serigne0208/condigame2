using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodinGame.A_Tester
{
    class _52_IdentifiantNumerique
    {
        public static int ComputeChekDigit(string identificationNumber)
        {
            List<int> Somme = new List<int>();

            for (int i = 0; i < identificationNumber.Length; i += 2)
                Somme.Add(int.Parse(identificationNumber.Substring(i, 1)));

            int s = Somme.Sum() * 3;

            Somme = new List<int>();
            for (int i = 1; i < identificationNumber.Length; i += 2)
                Somme.Add(int.Parse(identificationNumber.Substring(i, 1)));

            s += Somme.Sum();

            return s.ToString().Substring(s.ToString().Length - 1, 1).Equals(0) ? 0 : 10 - int.Parse(s.ToString().Substring(s.ToString().Length - 1, 1));

        }
    }
}
