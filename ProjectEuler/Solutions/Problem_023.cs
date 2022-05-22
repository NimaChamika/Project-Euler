using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_023
    {
        //https://projecteuler.chat/viewtopic.php?p=56541&hilit=23#p56541
        static List<int> abundantList = new List<int>();

        internal static void Solution()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int sum = 0;
            bool checkBool = false;

            for (int i = 12; i <= 20161; i +=1)
            {
                if(IsAbundant(i))
                {
                    abundantList.Add(i);
                }
            }


            for (int i=1;i<= 20161; i++)
            {
                checkBool = false;

                for(int j=12;j*2<=i;j++)
                {
                    int x = j;
                    int y = i - j;

                    bool check1 = IsInAbundantList(x);
                    bool check2 = IsInAbundantList(y);

                    if(check1 && check2)
                    {
                        checkBool = true;
                        break;
                    }
                }

                if(!checkBool)
                {
                    sum += i;
                }
            }



            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine(sum);
        }

        static bool IsAbundant(int i)
        {
            int sum = 0;
            for (int j = 1; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                    if (i / j != i && j * j != i)
                    {
                        sum += i / j;
                    }
                }
            }

            return sum > i;
        }

        //BINARY SEARCH
        private static bool IsInAbundantList( int value)
        {
            int l = 0;
            int r = abundantList.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;


                if (abundantList[mid] > value)
                {
                    r = mid - 1;
                }
                else if (abundantList[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}



//internal static void Solution()
//{
//    Stopwatch sw = new Stopwatch();
//    sw.Start();

//    List<int> abundantNumList = FindAllAbundantNumbers();


//    List<int> newList = new List<int>();
//    int sum = 0;
//    //string sumString = "";


//    for (int i = 0; i < abundantNumList.Count; i++)
//    {
//        //Console.WriteLine("* " + i);
//        for (int j = i; j < abundantNumList.Count; j++)
//        {
//            sum = abundantNumList[i] + abundantNumList[j];
//            if (sum > 28123)
//            {
//                break;
//            }
//            if (!newList.Contains(sum))
//            {
//                newList.Add(sum);
//            }
//        }
//        //Console.WriteLine(newList.Count);5
//    }



//    int sum2 = 0;
//    for (int i = 0; i < 28123; i++)
//    {
//        if (!newList.Contains(i))
//        {
//            //Console.WriteLine(i);
//            sum2 += i;
//        }

//    }

//    sw.Stop();
//    Console.WriteLine(sw.ElapsedMilliseconds);

//    Console.WriteLine(sum2);
//}

//static List<int> FindAllAbundantNumbers()
//{
//    List<int> abundantNumberList = new List<int>();
//    int sum = 0;
//    for (int i = 12; i <= 28123; i += 1)
//    {
//        sum = 0;
//        for (int j = 1; j * j <= i; j++)
//        {
//            if (i % j == 0)
//            {
//                sum += j;
//                if (i / j != i && j * j != i)
//                {
//                    sum += i / j;
//                }
//            }
//        }

//        if (sum > i)
//        {
//            Console.WriteLine(i);
//            abundantNumberList.Add(i);
//        }
//    }
//    return abundantNumberList;
//}
