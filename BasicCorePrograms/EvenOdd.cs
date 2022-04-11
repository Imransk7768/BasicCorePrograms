using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOdd
    {
        public void OddEven()
        {
            int Num;
            Console.WriteLine("Enter a Number: ");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine( + Num +" is Even.");
            }
            else
            {
                Console.WriteLine(+ Num+" is Odd " + Num + "\n");
            }
        }
    }
}
