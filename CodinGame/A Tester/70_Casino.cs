using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.A_Tester
{
    class _70_Casino
    {
        public static int ComputeDayGains(int nbSeats, int[] payingGuests, int[] guestMovements)
        {
            int Gain = 0;
            int openSeats = nbSeats;
            int N = guestMovements.Length;
            bool[] State = new bool[(N / 2)];
            List<int> Log = new List<int>();
            List<int> Queue = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int GM = guestMovements[i];
                if (State[GM])
                {
                    openSeats++;
                    if (!Log.Contains(GM))
                    {
                        Gain += payingGuests[GM];
                        Log.Add(GM);
                    }
                    if (Queue.Count != 0)
                    {
                        State[(Queue[0])] = !State[(Queue[0])];
                        Queue.RemoveAt(0);
                        openSeats--;
                    }
                }
                else
                {
                    if (openSeats != 0)
                    {
                        State[GM] = !State[GM];
                        openSeats--;
                    }
                    else
                    { Queue.Add(GM); }
                }
            }
            return Gain;
        }
    }
}
