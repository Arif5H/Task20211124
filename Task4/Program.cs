using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
        /*3 digit number is given. 
         Type digit 7 in the end of this number. 
         Then find find 7% of the received number*/
        step1:
            Console.Write("Please enter 3-digit number: ");
            string numberstr = Console.ReadLine();
            double number = Convert.ToDouble(numberstr);
            Console.Clear();
            if (number >= 100 && number < 1000)
            {
                Console.WriteLine("The entered number: {0} is 3-digit number", number);
                Console.WriteLine($"Type 7 in the end of given number {number} ");
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number = number*10 +7;
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Let's find 7% of the received value {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.07;
            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 3-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            Console.WriteLine("The obtained number is {0}", number);
            Console.WriteLine("Please push any button to continue");
            Console.ReadKey();
            
            



        }
    }
}
