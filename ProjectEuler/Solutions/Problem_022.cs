using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_022
    {
        internal static void Solution()
        {
            string filePath = @"C:\Users\pc\Desktop\names.txt";
            List<string> nameList = ReadFile(filePath).Split(',').ToList();
            nameList.Sort();

            long finalSum = 0;

            for (int i = 0; i < nameList.Count; i++)
            {
                finalSum += (i + 1) * NameValue(nameList[i]);
            }
            Console.WriteLine(finalSum);
        }

        static string ReadFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }

        static long NameValue(string name)
        {
            name = name.Substring(1, name.Length - 2);
            long sum = 0;
            foreach (char c in name)
            {
                sum += c - 64;
            }
            return sum;
        }

    }
}
