using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
        /*2 dene 5 reqemli eded verilib.
         * Bu ededleri toplayib.
         * Alinan cavabin evveline ve axirina 5 artir.
         * Neticenin 5 % tap
         */
        step1:
            Console.Write("Please enter 1st 5 digit number: ");
            string numberstr1 = Console.ReadLine();
            int number1 = Convert.ToInt32(numberstr1);

            Console.Clear();
            step2:
            Console.Write("Please enter 2nd 5 digit number: ");
            string numberstr2 = Console.ReadLine();
            int number2 = Convert.ToInt32(numberstr2);
            Console.Clear();
            double Sum;
            if (number1 >= 10000 && number1 < 100000)
            {
                Console.WriteLine("The entered 1st number: {0} is 5-digit number", number1);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                if (number2 >= 10000 && number2 < 100000)
                {
                    Console.WriteLine("The entered 2nd number: {0} is 5-digit number", number2);
                    Console.WriteLine($"Find Total of these 2 values: {number1} and {number2}");
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Sum = number1 + number2;
                    Console.WriteLine($"The Sum of these Values is: {number1} + {number2} = {Sum}");
                    Console.WriteLine($"Type 5 in front and end of the received Sum {Sum}");
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Sum *= 500000;
                    Sum = Sum * 10 + 5;
                    Console.WriteLine("The received value is: {0} ", Sum);
                    Console.WriteLine("Find 5% of the newly achieved number {0}", Sum);
                    Console.WriteLine("Please push any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Sum *= 0.05;
                }
                else
                {
                    Console.WriteLine("The entered 2nd number: {0} isn't 5-digit number ", number2);
                    Console.WriteLine("Please Try Again!");
                    goto step2;
                }
                
                
            }
            else
            {
                Console.WriteLine("The entered  1st number: {0} isn't 5-digit number ", number1);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            Console.WriteLine("The 5% of the received number is {0}",Sum);
            Console.ReadKey();



        }
    }
}
