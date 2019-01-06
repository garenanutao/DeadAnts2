using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    public class Kata
    {
        public static int DeadAntCount(string ants)
        {
            int[] deadAntNum = { 0, 0, 0 };
            string deadAnts;
            if (ants == null) return 0;
            string[] antGroups = ants.Split(new char[] { ' ', '.' });
            foreach (string ant in antGroups)
            {
                deadAnts = ant.Replace("ant", "").Trim();
                if (deadAnts != "")
                {
                    foreach (char antHead in deadAnts)
                    {
                        if (antHead == 'a') deadAntNum[0]++;
                        if (antHead == 'n') deadAntNum[1]++;
                        if (antHead == 't') deadAntNum[2]++;
                    }
                }
            }
            int max = deadAntNum[0];
            if (max < deadAntNum[1]) max = deadAntNum[1];
            if (max < deadAntNum[2]) max = deadAntNum[2];
            return max;
        }
    }
}
