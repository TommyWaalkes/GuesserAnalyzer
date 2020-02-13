using System;
using System.Collections.Generic;
using System.Text;

namespace GuesserLab
{
    class GuesserElim : Guesser
    {
        public List<int> possibleNums = new List<int>();
       
        public GuesserElim(int min, int max)
        {
            this.min = min;
            this.max = max;
            for(int i = min; i< max + 1; i++)
            {
                possibleNums.Add(i);
            }
        }
        public override int GenerateGuess()
        {
            int output = possibleNums[0];
            possibleNums.RemoveAt(0);
            return output;
        }
        public override void Reset()
        {
            possibleNums.RemoveAll(o=>true);
            possibleNums = new List<int>();
            for(int i = min; i<max + 1; i++)
            {
                possibleNums.Add(i);
            }
        }
    }
}
