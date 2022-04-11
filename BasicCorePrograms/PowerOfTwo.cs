using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public void TwoPower()
        {
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int num = (int)Math.Pow(2, i);
                Console.WriteLine("2" + " " + "^" + " " + i + "=" + num+"\n");
            }
        }
    }
}
