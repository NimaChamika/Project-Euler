using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_010
    {
        internal static void Solution()
        {
            int i = 3;
            long sum = 2;
            while (i < 2000000)
            //while(i<1000)
            {
                if (IsPrime(i))
                {
                    sum += i;
                    //Console.WriteLine(i);
                }
                i+=2;
            }

            Console.WriteLine(sum);
        }

        static bool IsPrime(int x)
        {
            float a = 3;
            while (a*a <= x)
            {
                if (x % a == 0)
                {
                    return false;
                }
                a+=2;
            }

            return true;
        }
    }
}
