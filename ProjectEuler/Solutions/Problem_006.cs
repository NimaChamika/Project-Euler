using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_006
    {
        internal static void Solution1()
        {
            int sum = 0;
            int squared = 0;
            int result = 0;
            const int N = 100;


            for (int i = 1; i <= N; i++)
            {
                sum += i;
                squared += i * i;
            }
            result = sum * sum - squared;
            Console.WriteLine(result);
        }
        //TIME COMPLEXITY - O(n)

        internal static void Solution2()
        {
            long sum = 0;
            long squared = 0;
            long result = 0;

            const int N = 100;

            sum = N * (N + 1) / 2;
            squared = (N * (N + 1) * (2 * N + 1)) / 6;

            result = sum * sum - squared;
            Console.WriteLine(result);
        }
        //TIME COMPLEXITY - O(1)
    }
}
