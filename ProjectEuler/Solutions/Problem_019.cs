using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_019
    {
        static int allSundayCount = 0;

        internal static void Solution()
        {
            int firstSunday = 6;
            for (int i = 1901; i <= 2000; i++)
            {

                firstSunday = CalculateNumofSundaysInAYear(firstSunday, i);
            }

            Console.WriteLine(allSundayCount);
        }

        static int CalculateNumofSundaysInAYear(int firstSundayOfMonth, int year)
        {
            bool isLeapYear = false;
            int monthIndex = 1;
            int numOfDaysPerMonth = 0;
            int SundayOfMonth = firstSundayOfMonth;

            //if (firstSundayOfJan > 1)
            //{
            //    SundayOfMonth = firstSundayOfJan - 1;
            //}
            //else
            //{
            //    SundayOfMonth = firstSundayOfJan + 6;
            //}



            if (year % 100 == 0 && year % 400 == 0)
            {
                isLeapYear = true;
            }
            else if (year % 4 == 0)
            {
                isLeapYear = true;
            }

            for (monthIndex = 1; monthIndex <= 12; monthIndex++)
            {
                if (monthIndex == 1 || monthIndex == 3 || monthIndex == 5 || monthIndex == 7 || monthIndex == 8 || monthIndex == 10 || monthIndex == 12)
                {
                    numOfDaysPerMonth = 31;
                }
                else
                {
                    numOfDaysPerMonth = 30;
                }

                if (monthIndex == 2)
                {
                    if (isLeapYear)
                    {
                        numOfDaysPerMonth = 29;
                    }
                    else
                    {
                        numOfDaysPerMonth = 28;
                    }
                }

                while (true)
                {
                    if (SundayOfMonth <= numOfDaysPerMonth)
                    {
                        if (SundayOfMonth == 1)
                        {
                            allSundayCount++;
                        }

                        SundayOfMonth += 7;
                    }
                    else
                    {
                        SundayOfMonth = SundayOfMonth - numOfDaysPerMonth;
                        break;
                    }
                }

            }

            return SundayOfMonth;
        }
    }
}
