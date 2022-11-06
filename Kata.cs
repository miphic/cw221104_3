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
            a.Add(1);
            a.Add(1);
            a.Add(2);

            var t0 = DateTime.Now;
            psefibo.prepare(100000000);
            var t1 = DateTime.Now;
            psefibo.prepare(200000000);
            var t2 = DateTime.Now;
            psefibo.prepare(1000000009);
            var t3 = DateTime.Now;
            Console.WriteLine(
$@"100000000:   {t1.Subtract(t0)}  
200000000:   {t2.Subtract(t1)}
1000000009:  {t3.Subtract(t0)}");

        }

        static void prepare(int count)
        {
            int c;
            int o = 3;
            while(psefibo.count < count)
            {
                psefibo.a[psefibo.count] = psefibo.a[psefibo.count - 1] + psefibo.a[psefibo.count - 2];
                if (o > 20)
                {
                    psefibo.a[psefibo.count] %= 10; /// = c % 10;
                    psefibo.a[psefibo.count - 1] %= 10;
                    o = 0;
                }
                psefibo.count++;
                o++;
            }
            
        }

        public psefibo(int count)
        {
            int c;
            while (psefibo.count < count)
            {
                c = a[psefibo.count - 1] + a[psefibo.count - 2];
                if (c > 9)
                    a.Add(c % 10);
                else
                    a.Add(c);
            }
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
