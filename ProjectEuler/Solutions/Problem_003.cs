using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_003
    {
        internal static void Solution()
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            long number = 600851475143;
            long x = 3;
            long midPoint = (long)Math.Sqrt(number);

            while (true)
            {
                if (number % x == 0)
                {
                    if (IsPrime(x))
                    {
                        Console.WriteLine(x);
                    }
                }
                x++;

                if (x > midPoint)
                {
                    break;
                }
            }
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

        }

        static bool IsPrime(long x)
        {
            if (x % 2 == 0)//PRIME HAS TO BE ODD
            {
                return false;
            }

            float maxDivisor = (float)Math.Floor(Math.Sqrt(x));
            float a = 3;
            while (a <= maxDivisor)
            {
                if (x % a == 0)
                {
                    return false;
                }
                a++;
            }

            return true;


        }
    }
}

//NOTES

//Modulus opertaor is slow(also the division).Testing parity of numbers with a bitwise AND is much faster

//func isEven(x int) bool {
//	if x&1 == 0 {
//		return true
//	}
//	return false
//}


////////////////////////////////
//Alternative Solution

//##Fundamental Theorem of Arithmetic##

//Any integer greater than 1 is either a prime number, or can be written as a unique product of prime numbers(ignoring the order).

//Example:
//The number 12.
//We start with the smallest prime number(2).
//12/2 = 6, which means that 2 is a prime factor to 12.
//We try again to divide the remainder with 2 again:
//6/2 = 3. Three is a prime number as well, so we now have the complete factorization which is
//Prime factorization of 12 is 2,2,3 and we can check that 223=12.

//const long numm = 600851475143;
//long newnumm = numm;
//long largestFact = 0;

//int counter = 2;
//while (counter* counter <= newnumm) {
//    if (newnumm % counter == 0) {
//        newnumm = newnumm / counter;
//        largestFact = counter;
//    } else {
//        counter++;
//    }
//}
//if (newnumm > largestFact) { // the remainder is a prime number
//    largestFact = newnumm;
//}