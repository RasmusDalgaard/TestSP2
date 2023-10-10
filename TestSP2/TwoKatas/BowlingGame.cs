using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoKatas
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public BowlingGame()
        {

        }

        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int score()
        {
            int totalScore = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    totalScore += 10 + strikeBonus(frameIndex);   
                    frameIndex++;

                } else if (isSpare(frameIndex))
                {
                    totalScore += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                } else
                {
                    totalScore += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return totalScore;
        }

        private int sumOfPinsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
    }
}
