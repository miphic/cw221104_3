using System;

namespace CW221104_3_fibonachi
{

    static class extends
    {
        static public void Add(this Array obj, int k)
        {            
            psefibo.a[psefibo.count] = (ushort)k;
            psefibo.count++;
        }
    }

    public class psefibo
    {
        public static ushort[] a;
        public static int count;
        public static int Related;
        const int baseN=1024*1024;
        static psefibo()
        {
            psefibo.a = new ushort[baseN];
            a[0] = 1;
            a[1] = 1;
            a[2] = 2;
            count = 3;
            var t0 = DateTime.Now;
            int o = 3;

            for (var i = psefibo.count; i < psefibo.a.Length; ++i)
            {
                psefibo.a[i] = (ushort)(psefibo.a[i - 1] + psefibo.a[i - 2]);
                if (o > 15)
                {
                    psefibo.a[i] %= 10;
                    psefibo.a[i - 1] %= 10;
                    o = 0;
                }
                ++o;
            }
            psefibo.count = psefibo.a.Length;
            Related = psefibo.a.Length;
        }


        public psefibo(int count)
        {
            int o = 3;
            int i;
            while (psefibo.Related + psefibo.baseN < count)
            {

                i = psefibo.Related % psefibo.baseN;
                if (i == 0 && Related > 2)
                {
                    psefibo.a[0] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[psefibo.a.Length - 2]);
#if DEBUG 
                    i++;
#endif
                    psefibo.a[1] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[0]);
#if DEBUG
                    i++;
#endif
                    psefibo.Related += 2;
                    o += 2;
                }

                var start = psefibo.Related % psefibo.baseN;
                for (i = start; i < psefibo.a.Length; ++i)
                { 
                    
                    psefibo.a[i] = (ushort)(psefibo.a[i - 1] + psefibo.a[i - 2]);
                       
                    
                    if (o > 15)
                    {
                        psefibo.a[i] %= 10;
                        psefibo.a[i - 1] %= 10;
                        o = 0;
                    }
                    ++o;
                }
                psefibo.Related += psefibo.baseN-start;
            }
            var end = (count - psefibo.Related) % a.Length < 2 ? (count - psefibo.Related + 2) : (count - psefibo.Related);
            
            if (psefibo.Related > 2)
            {
                switch (psefibo.Related % psefibo.baseN)
                {
                    case 0:
                        a[0] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[psefibo.a.Length - 2]);
                        a[1] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[0]);
                        psefibo.Related += 2;
                        o += 2;
                        //i += 2;
                        break;
                    case 1:
                        a[1] = (ushort)(psefibo.a[0] + psefibo.a[a.Length - 1]);
                        psefibo.Related++;
                        o++;
                        break;
                }

                
            }
            var start2 = psefibo.Related % psefibo.baseN;
            for (i = start2; i < end ; ++i)
            {                
                
                psefibo.a[i] = (ushort)(psefibo.a[i - 1] + psefibo.a[i - 2]);
                if (o > 14)
                {
                    psefibo.a[i] %= 10;
                    psefibo.a[i - 1] %= 10;
                    o = 0;
                }
                ++o;
            }
            Related += i - start2;
            //?????
            //psefibo.count = (ushort)psefibo.a.Length;
        }
        public int LastFibDigit(int n) => (int)psefibo.a[(n - 1) % psefibo.baseN];
    }
    public class Kata
    {
        public static int LastFibDigit(int n)
        {
            var re = (new psefibo(n)).LastFibDigit(n);
            if (re > 9) re %= 10;
            return re;
        }
    }
}
