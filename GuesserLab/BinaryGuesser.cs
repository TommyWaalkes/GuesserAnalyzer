using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    class BinaryGuesser : Guesser
    {
        GuessingGame gg;
        public BinaryGuesser(int min, int max, GuessingGame gg)
        {
            this.min = min;
            this.max = max;
            this.gg = gg;
        }

        public override int GenerateGuess()
        {
            int mid = (max + min) / 2;
          
            if (min < max)
            {
                if (LastGuess == GuessQuality.TooHigh || LastGuess == GuessQuality.WayTooHigh)
                {
                    max = mid - 1;
                }
                else if (LastGuess == GuessQuality.TooLow || LastGuess == GuessQuality.WayTooLow)
                {
                    min = mid + 1;
                }
            }
            else if(LastGuess == GuessQuality.TooHigh || LastGuess == GuessQuality.WayTooHigh)
            {
                max--;
            }
            else if(LastGuess == GuessQuality.TooLow || LastGuess == GuessQuality.WayTooLow)
            {
                min++;
            }
                return mid;
        }
    }
}
