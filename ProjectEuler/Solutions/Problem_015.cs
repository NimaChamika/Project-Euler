using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    class Problem_015
    {
        static int gridSize = 20;
        static Dictionary<KeyValuePair<int, int>, long> pathDic = new Dictionary<KeyValuePair<int, int>, long>();

        internal static void Solution()
        {
            Console.WriteLine(FindPaths(0,0));
        }

        static long FindPaths(int x, int y)
        {
            long i = 0;

            long sum = 0;

            if (x < gridSize)
            {
                if (pathDic.ContainsKey(new KeyValuePair<int, int>(x + 1, y)))
                {
                    sum = pathDic[new KeyValuePair<int, int>(x + 1, y)];
                }
                else
                {
                    sum = FindPaths(x + 1, y);
                }

                if (!pathDic.ContainsKey(new KeyValuePair<int, int>(x + 1, y)))
                {
                    pathDic[new KeyValuePair<int, int>(x + 1, y)] = sum;
                }
                i += sum;
            }
            if (y < gridSize)
            {

                if (pathDic.ContainsKey(new KeyValuePair<int, int>(x, y + 1)))
                {
                    sum = pathDic[new KeyValuePair<int, int>(x, y + 1)];
                }
                else
                {
                    sum = FindPaths(x, y + 1);
                }

                if (!pathDic.ContainsKey(new KeyValuePair<int, int>(x, y + 1)))
                {
                    pathDic[new KeyValuePair<int, int>(x, y + 1)] = sum;
                }

                i += sum;
            }

            if (x == gridSize && y == gridSize)
            {
                return 1;
            }

            return i;
        }
    }
}
