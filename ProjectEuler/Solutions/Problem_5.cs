using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_5
    {
        internal static void Solution()
        {
            Console.WriteLine(LCMofArray(11,12,13,14,15,16,17,18,19,20));
        }

        private static long LCMofArray(params long[] arr)
        {
            return arr.Aggregate(LCM);
        }


        //LEAST COMMON MULTIPLE (12,18 -> 36)
        //https://en.wikipedia.org/wiki/Least_common_multiple#Computing_the_least_common_multiple
        private static long LCM(long a, long b)
        {
            return (a / GCD(a, b)) * b;
        }

        //static int LCM(int a, int b)
        //{
        //    return (b / GCD(a, b)) * a;
        //}


        //GREATEST COMMON DIVISOR (12,18 -> 6) 
        //https://en.wikipedia.org/wiki/Euclidean_algorithm#Implementations
        private static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        //static int GCD(int a, int b)
        //{
        //    while (b != 0)
        //    {
        //        int temp = b;
        //        b = a % b;
        //        a = temp;
        //    }
        //    return a;
        //}
    }
}
