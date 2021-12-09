using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
        /*4 dene 6 reqemli eded verilib.
         * Ededlerin hamisinin 10 faizini tap ve topla.
         * Sonra hamisinin 15 faizini tap ve topla. 
          Sonra yekunda alinanlar iki cavabi vur biri birine.
        Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.
         */
        step1:
            Console.Write("Please enter 1st 6 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);
            Console.Clear();
            if (number1 >= 100000 && number1 < 1000000)
            {
                Console.WriteLine("The entered 1st number: {0} is 6-digit number", number1);

            }
            else
            {
                Console.WriteLine("The entered  1st number: {0} isn't 6-digit number ", number1);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
        step2:
            Console.Write("Please enter 2nd 6 digit number: ");
            string numberstr2 = Console.ReadLine();
            double number2 = Convert.ToDouble(numberstr2);
            Console.Clear();
            if (number2 >= 100000 && number2 < 1000000)
            {
                Console.WriteLine("The entered 2nd number: {0} is 6-digit number", number2);

            }
            else
            {
                Console.WriteLine("The entered  2nd number: {0} isn't 6-digit number ", number2);
                Console.WriteLine("Please Try Again!");
                goto step2;
            }
        step3:
            Console.Write("Please enter 3rd 6 digit number: ");
            string numberstr3 = Console.ReadLine();
            double number3 = Convert.ToDouble(numberstr3);
            Console.Clear();
            if (number3 >= 100000 && number3 < 1000000)
            {
                Console.WriteLine("The entered 3rd number: {0} is 6-digit number", number3);


            }
            else
            {
                Console.WriteLine("The entered  3rd number: {0} isn't 6-digit number ", number3);
                Console.WriteLine("Please Try Again!");
                goto step3;
            }
        step4:
            Console.Write("Please enter 4th 6 digit number: ");
            string numberstr4 = Console.ReadLine();
            double number4 = Convert.ToDouble(numberstr4);
            Console.Clear();
            if (number4 >= 100000 && number4 < 1000000)
            {
                Console.WriteLine("The entered 4th number: {0} is 6-digit number", number4);


            }
            else
            {
                Console.WriteLine("The entered  4th number: {0} isn't 6-digit number ", number4);
                Console.WriteLine("Please Try Again!");
                goto step4;
            }
            double number5, number6, number7, number8;
            double sum1, sum2, Multiple;

            Console.WriteLine("Find 10% of all values and Sum them");
            number5 = number1 * 0.15;
            number6 = number2 * 0.15;
            number7 = number3 * 0.15;
            number8 = number4 * 0.15;
            number1 *= 0.1;
            number2 *= 0.1;
            number3 *= 0.1;
            number4 *= 0.1;
            sum1 = number1 + number2 + number3 + number4;
            Console.WriteLine($"10% of values are: {number1}, {number2}, {number3}, {number4} ");
            Console.WriteLine($"The Total of these values is: {sum1}");
            Console.WriteLine($"Find 15% of all original values and find their TOTAL");
            Console.WriteLine("Please push any button to continue");
            Console.ReadKey();
            Console.Clear();
            sum2 = number5 + number6 + number7 + number8;
            Console.WriteLine($"15% of original values are: {number5}, {number6}, {number7}, {number8}");
            Console.WriteLine($"The Total of these values is: {sum2}");
            Console.WriteLine($"Multiply the Totals of values 10% and 15% {sum1} * {sum2}");
            Console.WriteLine("Please push any button to continue");
            Console.ReadKey();
            Multiple = sum1 * sum2;
            Console.WriteLine($"By Multiplying the totals we get, {Multiple}");
            Console.WriteLine($"Find 10% of the received multiplication number {Multiple}");
            Multiple *= 0.1;
            Console.WriteLine($"10% of the received multiplication number is {Multiple}");
            Console.WriteLine($"Find 11% of the lats received 10% multiplication number, {Multiple}");
            Console.ReadKey();
            Multiple *= 0.11;
            Console.WriteLine($"11% of the lats received 10% multiplication number {Multiple}");
            Console.ReadKey();
        }
    }
}
