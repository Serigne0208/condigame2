using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.En_Cours
{
    public class CodeGolf
    {
        public static void ChoiseMountain()
        {
            // game loop       
            while (true)
            {
                int indiceMountain = 0, valueMountain = -1;
                for (int i = 0; i < 8; i++)
                {
                    int mountainH = int.Parse(Console.ReadLine());
                    if (mountainH > valueMountain)
                    {
                        indiceMountain = i;
                        valueMountain = mountainH;
                    }
                }
                Console.WriteLine(indiceMountain);
            }

        }
    }
}
