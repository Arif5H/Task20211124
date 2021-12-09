using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
        /*2 Numbers are given. 
         1st number is 4-digit number, 2nd number is 7-digit number.
         Find 4% of 1st number. 
         Find 9% of 2nd number. 
         Sum the numbers and find 10% of sum.
         */
        step1:
            Console.Write("Please enter 1st number: 4 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);

            Console.Clear();
        step2:
            Console.Write("Please enter 2nd number: 7 digit number: ");
            string numberstr2 = Console.ReadLine();
            double number2 = Convert.ToDouble(numberstr2);
            Console.Clear();
            double Sum;
            if (number1 >= 1000 && number1 < 10000)
            {
                Console.WriteLine("The entered 1st number: {0} is 4-digit number", number1);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                if (number2 >= 1000000 && number2 < 10000000)
                {
                    Console.WriteLine("The entered 2nd number: {0} is 7-digit number", number2);
                    Console.WriteLine($"Find 4% of the 4-digit number {number1}");
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    number1 *= 0.04;
                    Console.WriteLine($"4% of the 4-digit number is {number1}");
                    Console.WriteLine($"Find 9% of the 7-digit number {number2}");
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    number1*= 0.09;
                    Console.WriteLine("9% of the 7-digit number is {0}", number2);
                    Console.WriteLine($"Sum the numbers {number1} + {number2} and find 10% of sum");
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Sum = number1 + number2;
                    Console.WriteLine("Sum of values is {0}",Sum);
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Sum *= 0.1;
                }
                else
                {
                    Console.WriteLine("The entered 2nd number: {0} isn't 7-digit number ", number2);
                    Console.WriteLine("Please Try Again!");
                    goto step2;
                }


            }
            else
            {
                Console.WriteLine("The entered  1st number: {0} isn't 4-digit number ", number1);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            Console.WriteLine("The 10% of the Sum is {0}", Sum);
            Console.ReadKey();
        }
    }
}
