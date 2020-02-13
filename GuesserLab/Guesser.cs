using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    public abstract class Guesser
    {
        protected int min = 1;
        protected int max = 100;
        public abstract int GenerateGuess();
    }
}
