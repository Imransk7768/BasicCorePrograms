using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void harmonicSeries()
        {
            Console.WriteLine("Enter numbes Series");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("1/"+i);
                sum += 1 / i;
            }
            Console.WriteLine("\nThe sum of the series is"+sum);
        }
    }
}
