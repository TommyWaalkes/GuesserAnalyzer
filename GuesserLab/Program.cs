using System;

namespace GuesserLab
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GuessQuality output = GuessQuality.TooLow;
            GuessingGame gg = new GuessingGame();

            Counter c = new Counter(new RandomGuesser());
            int tries = c.CountTries();
            Console.WriteLine(tries);
            int tries2 = c.CountTries();
            Console.WriteLine(tries2);
            //while(output != GuessQuality.Match)
            //{
            //    Console.WriteLine("Please input a number between 1 and 100:");
            //    int input = int.Parse(Console.ReadLine());
            //    output = gg.MakeGuess(input);
            //    Console.WriteLine(output);
            //    if(output == GuessQuality.Match)
            //    {
            //        Console.WriteLine("You win!!!");
            //    }

            //}


        }
    }
}
