using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnyTest
{
    class Program
    {
        private static void Main(string[] args)
        {
            //more like probability state transition
            int[] dices = {1,2,3,4,5,6};
            const int NUM = 105;
            double[] steps = new double[NUM+1];
            steps[0] = 1;
            for (int i = 1; i <= NUM; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i - dices[j] < 0 || i - dices[j] >= 100)
                        continue;
                    steps[i] += steps[i - dices[j]] * 1 / 6;
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter("out.txt"))
                {
                    for (int i = 1; i <= NUM; i++)
                    {
                        sw.WriteLine("{0}\t{1}",i,steps[i]);
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
