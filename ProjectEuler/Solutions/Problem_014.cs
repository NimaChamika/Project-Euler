using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_014
    {

        internal static void Solution()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long number = 13;
            long count = 0;
            long maxCount = 0;
            long tempNum = 0;
            long startingNumber = 0;

            while (number < 1_000_000)
            {
                count = 0;
                tempNum = number;

                while (true)
                {

                    if (tempNum == 1)
                    {
                        count++;
                        break;
                    }

                    if ((tempNum & 1) == 1)//CHECK FOR ODD
                    {
                        tempNum = (tempNum * 3) + 1;
                    }
                    else
                    {
                        tempNum /= 2;
                    }
                    count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    startingNumber = number;
                }
                number++;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(maxCount + " " + startingNumber);
        }
    }
}
