using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    public enum GuessQuality
    {
        WayTooHigh, 
        TooHigh, 
        Match, 
        TooLow,
        WayTooLow
    }
    class GuessingGame
    {
        private int SecretNum { get; }
        public GuessingGame()
        {
            Random r = new Random();
            SecretNum = r.Next(1, 101);
        }
        public GuessingGame(int SecretNum)
        {
            this.SecretNum = SecretNum;
        }

        public GuessQuality MakeGuess(int input)
        {
            if(input == SecretNum)
            {
                return GuessQuality.Match;
            }
            else if(input > SecretNum)
            {
                int diff =  input - SecretNum;
                if(diff < 10)
                {
                    return GuessQuality.TooHigh;
                }
                else
                {
                    return GuessQuality.WayTooHigh;
                }
            }
            else
            {
                int diff = SecretNum - input;
                if (diff < 10)
                {
                    return GuessQuality.TooLow;
                }
                else
                {
                    return GuessQuality.WayTooLow;
                }
            }
        }

    }
}
