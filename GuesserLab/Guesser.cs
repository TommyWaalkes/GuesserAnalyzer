using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    public abstract class Guesser
    {
        protected int min = 1;
        protected int max = 100;
        public GuessQuality LastGuess { get; set; }
        public Guesser()
        {
            LastGuess = GuessQuality.Start;
        }
        public abstract int GenerateGuess();

        public virtual void Reset()
        {

        }
    }
}
