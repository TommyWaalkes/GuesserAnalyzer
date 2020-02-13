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
        WayTooLow,
        Start
    }
    public class GuessingGame
    {
        public int Min { get; set; }
        public int Max { get; set; }
        private int SecretNum { get; }
        public GuessQuality LastGuess = GuessQuality.Start;
        public GuessingGame()
        {
            Min = 1;
            Max = 100;
            Random r = new Random();
            SecretNum = r.Next(Min, Max +1);
        }
        public GuessingGame(int SecretNum, int Min, int Max)
        {
            this.Min = Min;
            this.Max = Max;
            this.SecretNum = SecretNum;
        }

        public GuessQuality MakeGuess(int input)
        {
            if(input == SecretNum)
            {
                LastGuess = GuessQuality.Match;
            }
            else if(input > SecretNum)
            {
                int diff =  input - SecretNum;
                if(diff < 10)
                {
                    LastGuess = GuessQuality.TooHigh;
                }
                else
                {
                    LastGuess = GuessQuality.WayTooHigh;
                }
            }
            else
            {
                int diff = SecretNum - input;
                if (diff < 10)
                {
                    LastGuess = GuessQuality.TooLow;
                }
                else
                {
                    LastGuess = GuessQuality.WayTooLow;
                }
            }
            return LastGuess;
        }

    }
}
