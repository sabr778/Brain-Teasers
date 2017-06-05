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
        private const int SUM = 13;

        private static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("out.txt"))
                {
                    sw.WriteLine("Age1\tAge2\tAge3\tProduct");
                    for (int i = 1; i <= SUM/2; i++)
                    {
                        for (int j = i; SUM - i - j >= j; j++)
                        {
                            int product = i*j*(SUM - i - j);
                            sw.WriteLine("{0}\t{1}\t{2}\t{3}", i, j, SUM - i - j, product);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        
 
    }

}
