using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_Jeffery_Yates
{
    public class DiceSimulator
    {

        private Random random = new Random();
        public int[] SimulateRolls(int numOfRolls)
        {
            int[] rollResults = new int[13];

            for (int rollCounter = 0; rollCounter < numOfRolls; rollCounter++) 
            {
                int firstRoll = random.Next(1, 7);
                int secondRoll = random.Next(1, 7);
                int rollSum = firstRoll + secondRoll;

                rollResults[rollSum]++;
            }
        
            return rollResults;

        }
    }
}