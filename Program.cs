using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int PIN = 1234;

            double PINch;

            Console.WriteLine("Please input your PIN");

            string PINin = Console.ReadLine();

            PINch = Convert.ToDouble(PINin);

            if (PINch == PIN)
            {
                Console.WriteLine("Correct PIN");
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }
        }
    }
}
