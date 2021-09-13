using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_2
    {
        internal static void Solution()
        {
            long fib1 = 1;
            long fib2 = 1;
            long result = 0;
            long summed = 0;

            while (result < 4000000)
            {
                if ((result % 2) == 0)
                {
                    summed += result;
                }

                result = fib1 + fib2;
                fib2 = fib1;
                fib1 = result;
            }
            Console.WriteLine(summed);
        }
    }
}

//NOTES
//MY SOLUTION IS BRUTE FORCING.
//WE CAN CONSIDER EVEN NUMBERS ONLY. WE CAN NOTICE THE PATTERN THAT EVERY THIRD NUMBER IS EVEN STARTING AT F3. SO IF WE CAN EXPRESS
//Fn INTERMS OF Fn-3, Fn-6 THEN WE ONLY HAVE TO DEAL WITH EVEN NUMBERS.

//SEQ - 0,1,1,2,3,5,8,13,21,34

//long fib3 = 2;
//long fib6 = 0;
//long result = 2;
//long summed = 0;

//while (result< 4000000) {
//    summed += result;

//    result = 4* fib3 + fib6;
//    fib6 = fib3;
//    fib3 = result;
//}

//TO REDUCE THE NUMBER OF WRITE OPERATIONS

//long[] fib = { 2, 0 };
//int i = 0;
//long summed = 0;
 
//while (fib[i] < 4000000) {
//    summed += fib[i];
//    i = (i + 1) % 2;
//    fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
//}