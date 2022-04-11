using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelConsonant
    {
        char ch;
        public void Alphabet()
        {
            Console.WriteLine("Please Enter the Alphabets:->");
            ch = Console.ReadKey().KeyChar;
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Entered Character is vowel");
            }
            else
            {
                Console.WriteLine("Entered Character is Consonent\n");
            }
        }
    }
}
