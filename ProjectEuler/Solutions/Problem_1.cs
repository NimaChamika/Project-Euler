using System;

namespace ProjectEuler.Solutions
{
    public class Problem_1
    {
        internal static void Solution()
        {
            int result = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}

//SECOND SOLUTION

//3+6+9+12+…+999 = 3* (1+2+3+4+…+333)
//5+10+15+20+…+995 = 5* (1+2+3+4+…+199)
//1+2+3+4+…+N = (N*(N+1)/2)

//Public void Solve()
//{
//    result = SumDivisbleBy(3, 999) + SumDivisbleBy(5, 999) - SumDivisbleBy(15, 999);
//}

//private int SumDivisbleBy(int n, int p)
//{
//    return n * (p / n) * ((p / n) + 1) / 2;
//}



//EXTRA
//Sum of the Terms of an Arithmetic Sequence
//To find the sum of the first n terms of an arithmetic sequence use the formula,
//sum = n*(a1+an)/2