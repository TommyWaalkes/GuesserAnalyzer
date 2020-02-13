using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuesserLab
{
    class Batcher
    {
        public List<int> RunBatch(string type)
        {
            Counter c;
            List<int> tries = new List<int>();
            for (int i = 1; i < 101; i++)
            {
              
                GuessingGame gg = new GuessingGame(i, 1,100);
                if (type == "random")
                {
                    c = new Counter(new RandomGuesser());
                }
                else if (type == "elim")
                {
                    c = new Counter(new GuesserElim(gg.Min,gg.Max));
                }
                else if (type == "merge")
                {
                    c = new Counter(new BinaryGuesser(gg.Min, gg.Max, gg));
                }
                else
                {
                    c = new Counter(new RandomGuesser());
                }
                
                int attempt = c.CountTries(gg);
                tries.Add(attempt);
            }
            PrintListInfo(tries, type);
            return tries;
        }

        public void PrintListInfo(List<int> tries, string GuesserName)
        {
            Console.WriteLine(GuesserName);
            Console.WriteLine($"Average Tries per game: {tries.Average()}");
            Console.WriteLine($"Best game: {tries.Min()} tries");
            Console.WriteLine($"Worst Game: {tries.Max()} tries");
            Console.WriteLine($"Mode: ");
            Console.WriteLine();
        }
    }
}
