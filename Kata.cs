using System;

namespace CW221104_3_fibonachi
{

    static class extends
    {
        static public void Add(this Array obj, int k)
        {            
            psefibo.a[psefibo.count]= k;
            psefibo.count++;
        }
    }

    public class psefibo 
    {
        public static int[] a;
        public static int count;
        static psefibo()
        {
            psefibo.a = new int[1000000009];
            a[0] = 1;
            a[1] = 1;
            a[2] = 2;
            count = 3;
            var t0 = DateTime.Now;
            int o = 3;
            for (var i = psefibo.count; i < psefibo.a.Length; ++i)
            {
                psefibo.a[i] = psefibo.a[i - 1] + psefibo.a[i - 2];
                if (o > 22)
                {
                    psefibo.a[i] %= 10;
                    psefibo.a[i - 1] %= 10;
                    o = 0;
                }
                ++o;
            }
            psefibo.count = psefibo.a.Length;
            var t3 = DateTime.Now;
            Console.WriteLine($@"1000000009:  {t3.Subtract(t0)}");
        }
        

        public psefibo(int count)
        {
            int o = 3;
            
                for (var i = psefibo.count; i < count; ++i )
                {
                    psefibo.a[i] = psefibo.a[i - 1] + psefibo.a[i - 2];
                    if (o > 22)
                    {
                        psefibo.a[i] %= 10;
                        psefibo.a[i - 1] %= 10;
                        o = 0;
                    }
                    ++o;
                }
                psefibo.count = psefibo.a.Length;
            //}
        }
        public int LastFibDigit(int n) => psefibo.a[n - 1];
    }
    public class Kata
    {
        public static int LastFibDigit(int n)
        {
            var re =  (new psefibo(n)).LastFibDigit(n);
            if (re > 9) re %= 10;
            return re; 
        }
    }
}
