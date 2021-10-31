using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_018
    {
        internal static void Solution()
        {
            string filePath = @"C:\Users\pc\Desktop\Input.txt";
            string s = FileReader(filePath);
            string[] numArray1 = s.Split('\n');
            List<string> numArray2 = new List<string>();
            List<int> sumArray = new List<int>();
            List<int> tempSumArray = new List<int>();
            List<int> indexList = new List<int>();
            List<int> tempIndexList = new List<int>();

            for (int i = 0; i < numArray1.Length; i++)
            {
                numArray2 = numArray1[i].Split(' ').ToList();
                tempSumArray.Clear();
                tempIndexList.Clear();

                tempSumArray.AddRange(sumArray);
                tempIndexList.AddRange(indexList);

                sumArray.Clear();
                indexList.Clear();

                if (tempSumArray.Count > 0)
                {

                    for (int j = 0; j < tempSumArray.Count; j++)
                    {
                        sumArray.Add(tempSumArray[j] + int.Parse(numArray2[tempIndexList[j]]));
                        indexList.Add(tempIndexList[j]);

                        sumArray.Add(tempSumArray[j] + int.Parse(numArray2[tempIndexList[j] + 1]));
                        indexList.Add(tempIndexList[j] + 1);
                    }

                }
                else
                {
                    sumArray.Add(int.Parse(numArray2[0]));
                    indexList.Add(0);
                }


            }
            Console.WriteLine(sumArray.Max());

        }

        static string FileReader(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
