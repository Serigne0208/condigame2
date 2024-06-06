using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.En_Cours
{
    class _71_SommeNombre
    {
         
        public static int ComputeJoinPoint(int s1, int s2)
        {
            int iteration = 0;
            while ((s1 != s2) && (iteration < 1000))
            {

                string ss1 = s1.ToString(), ss2 = s2.ToString();

                List<int> cs1 = new List<int>();

                cs1.Add(int.Parse(ss1));

                for (int i = 0; i < ss1.Length; i++) cs1.Add(int.Parse(ss1.Substring(i, 1)));


                List<int> cs2 = new List<int>
                {
                    int.Parse(ss2)
                };

                for (int i = 0; i < ss2.Length; i++) cs2.Add(int.Parse(ss2.Substring(i, 1)));



                s1 = cs1.Sum();
                s2 = cs2.Sum();

                iteration += 1;
            }

            return (s1 == s2) ? s1 : s2;


        }
    }
}
