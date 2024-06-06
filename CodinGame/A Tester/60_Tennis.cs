using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.A_Tester
{
    class _60_Tennis
    {
        public static string ComputeGameState(string nameP1, string nameP2, string[] wins)
        {

            int scoreP2 = wins.Where(c => c.Equals("P2")).Count();
            int scoreP1 = wins.Where(r => r.Equals("P1")).Count();

            string[] gameScoreChoice = { "0", "15", "30", "40", "DEUCE", "ADVANTAGE", "WINS" };



            if (scoreP1 > 4 && scoreP1 - scoreP2 == 1)
            {
                return string.Format("{0} {1}", nameP1, gameScoreChoice[5]); // ADVANTAGE
            }
            else if (scoreP2 > 4 && scoreP2 - scoreP1 == 1)
            {
                return string.Format("{0} {1}", nameP2, gameScoreChoice[5]); // ADVANTAGE
            }
            else if (scoreP1 == scoreP2)
            {
                return gameScoreChoice[4]; // DEUCE
            }
            else if (scoreP1 >= 4 && (scoreP1 - scoreP2 >= 2 || scoreP2 == 0))
            {
                return string.Format("{0} {1}", nameP1, gameScoreChoice[6]); // WINS
            }
            else if (scoreP2 >= 4 && (scoreP1 - scoreP2 >= 2 || scoreP1 == 0))
            {
                return string.Format("{0} {1}", nameP2, gameScoreChoice[6]); // WINS
            }
            else
            {
                return string.Format("{0} {1} - {2} {3}", nameP1, gameScoreChoice[scoreP1], nameP2, gameScoreChoice[scoreP2]);
            }

        }
    }
}
