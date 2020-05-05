using System;
using CodingChallenges.Problems;

namespace CodingChallenges.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Staircase staircase = new Staircase(4);
            //staircase.Build();

            BirthdayCake cake = new BirthdayCake(new int[] { 4, 4, 1, 3 });
            cake.GetTallestCandles();
        }
    }
}
