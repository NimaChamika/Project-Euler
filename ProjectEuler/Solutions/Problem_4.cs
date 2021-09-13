using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_4
    {
        internal static void Solution()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                palin = MakePalindrome(firstHalf);
                int midPoint = (int)Math.Sqrt(palin);
                for (int i = midPoint; i>=100; i--)
                {
                    if(palin/i > 1000)
                    {
                        continue;
                    }

                    if ((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine(palin);
        }

        static int MakePalindrome(int fHalf)
        {
            string _firstHalf = fHalf.ToString();
            string _secondHalf = new string(_firstHalf.Reverse().ToArray());
            return int.Parse(_firstHalf + _secondHalf);
        }
    }
}
