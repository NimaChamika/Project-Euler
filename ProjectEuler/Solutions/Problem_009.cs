using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_009
    {
        internal static void Solution()
        {
            int a, b, c = 0;

            int m = 2;

            bool until = true;

            while (until)
            {
                for (int n = 1; n < m; ++n)
                {
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;

                    if (a + b + c == 1000)
                    {
                        Console.WriteLine("{0} {1} {2}", a.ToString(), b.ToString(), c.ToString());
                        Console.WriteLine(a * b * c);
                        until = false;
                        break;
                    }

                }
                m++;
            }
        }
    }
}

//https://en.wikipedia.org/wiki/Pythagorean_triple
