using System;

namespace BasicCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. LeapYear\n3. PowerOfTwo\n4. PrimeFactor\n5. HarmonicSeries\n6. Quotient&Remainder\n" +
                "7. SwapTwoNumbers");
            while (end)
            {
                Console.WriteLine("Enter an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FLipCoin flipCoin = new FLipCoin();
                        flipCoin.Flip();
                        break;
                    case 2:
                        LeapYear year = new LeapYear();
                        year.CheckLeapYear();
                        break;
                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.TwoPower();
                        break;
                    case 4:
                         PrimeFactor prime = new PrimeFactor();
                        prime.Prime();
                        break;
                    case 5:
                        HarmonicNumber Hnum = new HarmonicNumber();
                        Hnum.harmonicSeries();
                        break;
                    case 6:
                        QuotientRemainder qr = new QuotientRemainder();
                        qr.CalQuotientRemainder();
                        break;
                    case 7:
                        SwapTwoNumbers swap = new SwapTwoNumbers();
                        swap.DoSwapTwoNumbers();
                        break;
                    case 8:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Option To Execute");
                        break;
                }
            }
        }
    }
}