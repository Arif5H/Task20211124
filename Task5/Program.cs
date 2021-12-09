using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
        /*4 Digit number is given. 
         Type digit 4 in front of this value.
         Type 44 in the end of the gotten value 
         Find 44% of the finalezed obtained value.*/
        step1:
            Console.Write("Please enter 4-digit number: ");
            string numberstr = Console.ReadLine();
            double number = Convert.ToDouble(numberstr);
            Console.Clear();
            if (number >= 1000 && number < 10000)
            {
                Console.WriteLine("The entered number: {0} is 4-digit number", number);
                Console.WriteLine($"Type 4 in front of given number {number} ");
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number += 40000;
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Please type 44 in the end of the received value {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number = number * 100 + 44;
                Console.WriteLine("The obtained number is {0}", number);
                Console.WriteLine("Let's find 44% of the finally obtained number {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.44;
            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 4-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
                Console.WriteLine("The obtained value is {0}", number);
             Console.ReadKey();



        }
    }
}
