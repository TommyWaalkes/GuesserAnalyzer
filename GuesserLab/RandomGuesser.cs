using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    class RandomGuesser : Guesser
    {
        public override int GenerateGuess()
        {

            Random r = new Random();
            return r.Next(min, max + 1);
        }
    }
}
