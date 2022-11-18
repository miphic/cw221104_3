using System;
using System.Linq;

namespace CW221104_3_fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            var t0 = DateTime.Now;
            Console.WriteLine($@" 1 {Kata.LastFibDigit(1) }");
            Console.WriteLine($@" 6 { Kata.LastFibDigit(21)}");
            Console.WriteLine($@" 9 { Kata.LastFibDigit(31)}");
            Console.WriteLine($@" ? { Kata.LastFibDigit(35)}");
            Console.WriteLine($@" ? { Kata.LastFibDigit(37)}");
            Console.WriteLine($@" 1 { Kata.LastFibDigit(302)}");
            Console.WriteLine($@" 7 { Kata.LastFibDigit(4003)}");
            Console.WriteLine($@" 8 { Kata.LastFibDigit(50004)}");
            Console.WriteLine($@" 5 { Kata.LastFibDigit(600005)}");
            Console.WriteLine($@" 3 { Kata.LastFibDigit(7000006)}");
            Console.WriteLine($@" 8 { Kata.LastFibDigit(80000007)}");
            Console.WriteLine($@" 1 { Kata.LastFibDigit(900000008)}");
            Console.WriteLine($@" 9 { Kata.LastFibDigit(1000000009)}");
            int ffd = int.MaxValue;
                                                        //999292929
            var t1 = DateTime.Now;
            Console.WriteLine($@"{t1.Subtract(t0)}");
           // psefibo.printpredata();
            
        }
    }
}
