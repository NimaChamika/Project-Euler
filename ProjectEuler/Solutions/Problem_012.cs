using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_012
    {
        internal static void Solution()
        {
            long number = 0;
            long incrementer = 1;

            int numOfDivisors;

            while (true)
            {
                numOfDivisors = 0;
                number += incrementer;

                int i = 1;
                while((i*i) <= number)
                {
                    if (number % i == 0)
                    {
                        numOfDivisors+=2;
                    }
                    i++;
                }
                //Console.WriteLine(numOfDivisors);
                if (numOfDivisors >= 500)
                {
                    break;
                }

                incrementer++;
            }

            Console.WriteLine(number);
        }
    }
}
