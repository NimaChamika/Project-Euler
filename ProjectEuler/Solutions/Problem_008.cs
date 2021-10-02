using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_008
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\input.txt";
        static string x = "";

        internal static void Solution()
        {
            ReadNumber();
            //Console.WriteLine(x);
            BigInteger maxProduct = int.MinValue;
            for(int i=0;i<=x.Length-13;i++)
            {
                BigInteger product = 1;

                for (int j=i;j<i+13;j++)
                {
                    product *= BigInteger.Parse(x[j].ToString());
                }

                //Console.WriteLine(product);
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            Console.WriteLine(maxProduct);
        }

        static void ReadNumber()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    x += sr.ReadLine();
                }
            }
        }
    }
}
