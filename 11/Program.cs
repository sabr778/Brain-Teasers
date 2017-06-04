//#define SHOW_PINVOKE_BUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace AnyConsoleTest
{
    internal class Program
    {
        private static int N = 100;
        private static int[] coins = new[] { 1, 2,5, 10 };
        private static int[] solutions = new int[N+1];
        private static void Main(string[] args)
        {
            solutions[0] = 1;
            coinExchange(N,4);
            Console.WriteLine(solutions[N]);
            //int x = coinExchangeRecursion(N, 4);
            //Console.WriteLine(x);
            Console.ReadKey();
        }

        private static void coinExchange(int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = coins[i]; j <= n; j++)
                {
                    solutions[j] += solutions[j - coins[i]];
                }
            }
        }

        private static int coinExchangeRecursion(int n, int m) 
        {
            if (n == 0) 
                return 1;
            if (n < 0 || m == 0)
                return 0;
            return (coinExchangeRecursion(n, m - 1) + coinExchangeRecursion(n - coins[m - 1], m));
        }
 
    }

}
