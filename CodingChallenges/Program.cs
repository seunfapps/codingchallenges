using System;
using CodingChallenges.Problems;

namespace CodingChallenges.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Staircase staircase = new Staircase(4);
            staircase.Build();
        }
    }
}
