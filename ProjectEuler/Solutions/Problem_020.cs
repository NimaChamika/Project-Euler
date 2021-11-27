using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_020
    {
        internal static void Solution()
        {
            string num = Factorial(100).ToString();
            Console.WriteLine(num.Select(c=>int.Parse(c.ToString())).Sum());
        }

        static BigInteger Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
