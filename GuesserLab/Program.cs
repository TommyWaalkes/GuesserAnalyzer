using System;
using System.Collections.Generic;

namespace GuesserLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Batcher b = new Batcher();
            List<int> randomTries = b.RunBatch("random");

            List<int> elimTries = b.RunBatch("elim");

            List<int> MergeSearch = b.RunBatch("merge");
        }

        public void PlayGame()
        {
            GuessQuality output = GuessQuality.TooLow;

            while (output != GuessQuality.Match)
            {
                GuessingGame gg = new GuessingGame();
                Console.WriteLine("Please input a number between 1 and 100:");
                int input = int.Parse(Console.ReadLine());
                output = gg.MakeGuess(input);
                Console.WriteLine(output);
                if (output == GuessQuality.Match)
                {
                    Console.WriteLine("You win!!!");
                }

            }
        }
    }
}
