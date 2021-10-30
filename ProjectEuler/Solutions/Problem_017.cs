using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_017
    {
        static string[] unit1Array;
        static string[] unit2Array;

        internal static void Solution()
        {
            unit1Array = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            unit2Array = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int count = 0;
            Regex pattern = new Regex("[- ]");
            string newNum;// = 

            for (int i = 1; i <= 1000; i++)
            {
                newNum = pattern.Replace(NumberToWord(i), "");
                count += newNum.Length;
            }

            Console.WriteLine(count);
        }

        private static string NumberToWord(int number)
        {
            if (number < 0)
            {
                return string.Empty;
            }
            if (number <= 19)
            {
                return unit1Array[number - 1];
            }
            else if (number == 1000)
            {
                return "one thousand";
            }
            else if (number % 100 <= 19)
            {
                if (number % 100 == 0)
                {
                    return unit1Array[number / 100] + " hundred";
                }
                return unit1Array[number / 100] + " hundred and " + unit1Array[(number % 100) - 1];
            }
            else
            {

                if (number <= 100)
                {
                    if (number % 10 == 0)
                    {
                        int tenFactor = int.Parse(number.ToString()[0].ToString());
                        return unit2Array[tenFactor - 2];
                    }
                    else
                    {
                        int tenFactor = int.Parse(number.ToString()[0].ToString());
                        int unitFactor = int.Parse(number.ToString()[1].ToString());
                        return unit2Array[tenFactor - 2] + "" + unit1Array[unitFactor - 1];
                    }
                }
                else
                {
                    if (number % 10 == 0)
                    {
                        int hunderedFactor = number / 100;
                        int tenFactor = int.Parse(number.ToString()[1].ToString());
                        return unit1Array[hunderedFactor - 1] + " hundred and " + unit2Array[tenFactor - 2];
                    }
                    else
                    {
                        int hunderedFactor = number / 100;
                        int tenFactor = int.Parse(number.ToString()[1].ToString());
                        int unitFactor = int.Parse(number.ToString()[2].ToString());
                        return unit1Array[hunderedFactor - 1] + " hundred and " + unit2Array[tenFactor - 2] + "" + unit1Array[unitFactor - 1];
                    }
                }


            }
        }
    }
}
