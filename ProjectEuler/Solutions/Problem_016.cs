using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_016
    {
        internal static void Solution()
        {
            int sum = 0;
            BigInteger result = (BigInteger)Math.Pow(2, 1000);
            sum = result.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).Sum();
            Console.WriteLine(sum);
        }
    }
}
