using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_013
    {
        internal static void Solution()
        {
            BigInteger bigInteger = new BigInteger();

            using (StreamReader reader = new StreamReader(@"C:\Users\pc\Desktop\Input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    bigInteger += BigInteger.Parse(line);
                }

                Console.WriteLine(bigInteger.ToString().Substring(0, 10));
            }
        }
    }
}
