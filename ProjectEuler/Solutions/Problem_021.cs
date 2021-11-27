using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_021
    {
        internal static void Solution()
        {
            List<int> amicableNumbersList = new List<int>();

            int amicableNum2 = 0;
            int amicableNum1 = 0;

            for (int i = 1; i < 10000; i++)
            {
                if (!amicableNumbersList.Contains(i))
                {
                    amicableNum2 = SumOfDivisors(i);
                    amicableNum1 = SumOfDivisors(amicableNum2);

                    if (i == amicableNum1 && i != amicableNum2)
                    {
                        amicableNumbersList.Add(i);
                        amicableNumbersList.Add(amicableNum2);
                    }
                }

            }

            //Console.WriteLine(amicableNumbersList.Count);
            int sum = 0;

            foreach (int i in amicableNumbersList)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }

        static int SumOfDivisors(int n)
        {
            int sum = 0;

            for (int i = 1; i * i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i > 1)
                    {
                        sum += n / i;
                    }
                }
            }

            return sum;
        }
    }
}
