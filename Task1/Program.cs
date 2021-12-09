using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4-digit Number is given.
               In front of this Number type 7
               In the end of  of this Number add 8.
               Example1: 333 = 73338*/
            step1:
            Console.Write("Please enter 4-digit number: ");
            string numberstr = Console.ReadLine();
            int number = Convert.ToInt32(numberstr);
            Console.Clear();
            if (number>=1000 && number < 10000)
            {
                Console.WriteLine("The entered number: {0} is 4-digit number", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Type 7 in front of given number {number} ");
                number += 70000;
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Please add digit 8 in the end of the received value {0}", number);
                number = number * 10 + 8;
            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 4-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            Console.WriteLine("The obtained number is {0}", number);
            Console.ReadKey();
        }
    }
}
