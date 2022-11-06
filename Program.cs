using System;

namespace CW221104_3_fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kata.LastFibDigit(10000000000);
            Console.WriteLine($@"{Kata.LastFibDigit(1) }");
            Console.WriteLine($@"{ Kata.LastFibDigit(21)}");
            Console.WriteLine($@"{ Kata.LastFibDigit(302)}");
            Console.WriteLine($@"{ Kata.LastFibDigit(4003)}");
            Console.WriteLine($@"{ Kata.LastFibDigit(50004)}");
            Console.WriteLine($@"{ Kata.LastFibDigit(600005)}");
            Console.WriteLine($@"{ Kata.LastFibDigit(7000006)}");
        }
    }
}
