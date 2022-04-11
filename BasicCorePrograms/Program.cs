using System;

namespace BasicCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. LeapYear\n3. PowerOfTwo\n");
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
                    default:
                        Console.WriteLine("Please Enter a Valid Option To Execute");
                        break;
                }
            }
        }
    }
}