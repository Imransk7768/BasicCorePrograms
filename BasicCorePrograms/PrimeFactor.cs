using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactor
    {
        public void Prime()
        {
            int i = 0, num = 0, factorial = 1;
            Console.Write("Enter the Number to check factorial of it:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            factorial *= i;
            Console.Write("The Factorial of "+ num+ " is : "+factorial +" \n");
        }
    }
}
