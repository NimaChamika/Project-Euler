using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_7
    {
        internal static void Solution()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long i = 11;
            int index = 4;
            while (true)
            {
                if (IsPrime(i))
                {
                    index++;
                    if (index == 10001)
                    {
                        break;
                    }
                }
                i += 2;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(i);
        }

        static bool IsPrime(long x)
        {
            //if (x % 2 == 0)
            //{
            //    return false;
            //}

            float a = 3;

            //float maxDivisor = (float)Math.Floor(Math.Sqrt(x));
            //while (a <= maxDivisor)
            //{
            //    if (x % a == 0)
            //    {
            //        return false;
            //    }
            //    a += 2;
            //}

            while ((a * a) <= x)
            {
                if (x % a == 0)
                {
                    return false;
                }
                a += 2;
            }

            return true;
        }
    }
}
