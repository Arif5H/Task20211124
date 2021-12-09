using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
        /*4 Digit Number is given. 
         * Find 20% of the number , 
         * Then find 10% of answer. 
         * Find square of the final answer.*/

        step1:
            Console.Write("Please enter 4-digit number: ");
            string numberstr = Console.ReadLine();
            double number = Convert.ToDouble(numberstr);
            Console.Clear();
            if (number >= 1000 && number < 10000)
            {
                Console.WriteLine("The entered number: {0} is 4-digit number", number);
                Console.WriteLine($"Let's find 20% of the given number {number}");
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.2;
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Let's find 10% of the of the new received number {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.1;
                Console.WriteLine("The obtained number is {0}", number);
                Console.WriteLine("Let's find square, of the obtained number {0}",number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= number;
                Console.WriteLine("The squared value of the obtained value is {0}",number);
            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 4-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            Console.ReadKey();
        }
    }
}
