using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CW221104_3_fibonachi
{
    public class fibocollection
    {
        int limit;
        static SortedSet<long> a = new SortedSet<long>();
        public fibocollection(int number)
        {
            limit = number;
            if (limit < 1)
                throw new ArgumentOutOfRangeException("ограничитель числа фибоначи не может быть 0 или отрицательны числом.");
            if (a.Count == 0)
            {
                a.Add(0);
                a.Add(1);
            }
            while (add_f())
            { }
        }
        
        bool add_f()
        {
            long n = a.TakeLast(1).Single() + a.SkipLast(1).TakeLast(1).Single();
            if (n < limit)
            {
                a.Add(n);
                return true;
            }
            else
                return false;
        }

        static long get_before(long n)
        { a. }
    }
    public class Kata
    {
        public static int LastFibDigit(long n)
        {
            var b = new fibocollection(6);
            return 0;
        }
    }
}
