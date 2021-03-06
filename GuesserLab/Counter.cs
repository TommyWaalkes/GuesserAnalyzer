﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    class Counter
    {
        private Guesser g;
        public Counter(Guesser g)
        {
            this.g = g;
        }

        public int CountTries(GuessingGame gg)
        {
            GuessQuality output = GuessQuality.Start;
            int tries = 0;
            while (output != GuessQuality.Match)
            {
                tries++;
                int guess = g.GenerateGuess();
                output = gg.MakeGuess(guess);
                g.LastGuess = output;
            }

            return tries;
        }
    }
}
