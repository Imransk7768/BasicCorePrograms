using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientRemainder
    {
        public void CalQuotientRemainder()
        {
            Console.WriteLine("Enter number for Dividend:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number fir Divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder +"\n");
        }
    }
}
