using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public void FindLargestNum()
        {
            int a, b, c;

            Console.WriteLine("largest among three numbers:");
            Console.Write("Enter value for a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for c : ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine(+a+" is largest number");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine(+b+" is largest number");
            }
            else if ((c > a) && (c > b))
            {
                Console.WriteLine(+c+" is largest number");
            }
            else
                Console.WriteLine("{0} is constat number", a, b, c);
            {

            }
        }
    }
}
