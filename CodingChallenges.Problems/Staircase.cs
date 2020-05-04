using System;
using System.Text;

namespace CodingChallenges.Problems
{
    public class Staircase
    {
        private int steps;
        public Staircase(int steps)
        {
            this.steps = steps;
        }
        public void Build()
        {
            for(int i = 1; i <= steps; i++)
            {
                string text = new String('#', i);
                Console.WriteLine(text.PadLeft(steps));
            }
        }
    }
}
