using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class forU
    {
        public static void l()
        {
            int h = 5, k = 25;
            string s = " ", c = "*";
            int[][] arr = new int[][]{
                new[] { 4, 7, 10, 5, 3, 1 },
                new[] { 25, 25, 23, 21, 17, 13, 9, 5, 1, 0, 0, 1, 2, 4, 6, 8, 10, 12 },
            };
            while (h-- > 0) Console.WriteLine();
            Action<int, string> w = (l, ch) => { for (int j = 0; j < l; j++) Console.Write(ch); };
            for (int i = 0; i < arr[0].Length / 2; i++)
            {
                w(arr[0][arr[0].Length / 2 + i] + k, s);
                w(arr[0][i], c);
                w(arr[0][arr[0].Length / 2 + i] + 2, s);
                w(arr[0][i], c);
                Console.WriteLine();
            }
            for (int i = 0; i < arr[1].Length / 2; i++)
            {
                w(arr[1][arr[1].Length / 2 + i] + k, s);
                w(arr[1][i], c);
                Console.WriteLine();
            }
        }
    }
}
