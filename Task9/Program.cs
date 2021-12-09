using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
        /*3 dene 6 reqemli eded verilib. 
         * Her birinin 10 faizini tapib neticeleri topla.
         * Alinan cavabin 10% tap.
         */
        step1:
            Console.Write("Please enter 1st 6 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);

            Console.Clear();
        step2:
            Console.Write("Please enter 2nd 6 digit number: ");
            string numberstr2 = Console.ReadLine();
            double number2 = Convert.ToDouble(numberstr2);
            Console.Clear();
            step3:
            Console.Write("Please enter 3rd 6 digit number: ");
            string numberstr3 = Console.ReadLine();
            double number3 = Convert.ToDouble(numberstr3);
            Console.Clear();
            double Sum;
            if (number1 >= 100000 && number1 < 1000000)
            {
                Console.WriteLine("The entered 1st number: {0} is 6-digit number", number1);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                if (number2 >= 100000 && number2 < 1000000)
                {   
                    Console.WriteLine("The entered 2nd number: {0} is 6-digit number", number2);
                    Console.WriteLine("Please push any button to continue");
                    if (number3 >= 100000 && number3 < 1000000)
                    {
                        Console.WriteLine("The entered 3rd number: {0} is 6-digit number", number3);
                        Console.WriteLine($"Find 10% of each of these 6-digit numbers {number1}, {number2}, {number3}");
                        Console.WriteLine("Please push any button to continue");
                        Console.ReadKey();
                        Console.Clear();
                        number1 *= 0.1;
                        number2 *= 0.1;
                        number3 *= 0.1;
                        Console.WriteLine($"10% of each of these numbers as follows: {number1}, {number2},{number3}");
                        Console.WriteLine($"Sum the numbers {number1} + {number2} + {number3} and find 10% of sum");
                        Console.WriteLine("Please push any button to continue");
                        Console.ReadKey();
                        Console.Clear();
                        Sum = number1 + number2+number3;
                        Console.WriteLine($"Sum the numbers {number1} + {number2} +{number3} is {Sum}");
                        Console.WriteLine("Please push any button to continue");
                        Console.ReadKey();
                        Sum *= 0.1;
                    }
                    else
                    {
                        Console.WriteLine("The entered 3rd number: {0} isn't 6-digit number ", number3);
                        Console.WriteLine("Please Try Again!");
                        goto step3;
                    }
                }
                else
                {
                    Console.WriteLine("The entered 2nd number: {0} isn't 6-digit number ", number2);
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
