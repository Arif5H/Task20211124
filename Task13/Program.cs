using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
        /*5 dene eded verilib. 
         * Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
         * 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine. 
           Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla.
           Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.
         */
        step1:
            Console.Write("Please enter 1st 5 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);
            Console.Clear();
            if (number1 >= 10000 && number1 < 100000)
            {
                Console.WriteLine("The entered 1st number: {0} is 5-digit number", number1);

            }
            else
            {
                Console.WriteLine("The entered  1st number: {0} isn't 5-digit number ", number1);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
        step2:
            Console.Write("Please enter 2nd 5 digit number: ");
            string numberstr2 = Console.ReadLine();
            double number2 = Convert.ToDouble(numberstr2);
            Console.Clear();
            if (number2 >= 10000 && number2 < 100000)
            {
                Console.WriteLine("The entered 2nd number: {0} is 5-digit number", number2);

            }
            else
            {
                Console.WriteLine("The entered  2nd number: {0} isn't 5-digit number ", number2);
                Console.WriteLine("Please Try Again!");
                goto step2;
            }
        step3:
            Console.Write("Please enter 3rd 5 digit number: ");
            string numberstr3 = Console.ReadLine();
            double number3 = Convert.ToDouble(numberstr3);
            Console.Clear();
            if (number3 >= 10000 && number3 < 100000)
            {
                Console.WriteLine("The entered 3rd number: {0} is 5-digit number", number3);


            }
            else
            {
                Console.WriteLine("The entered  3rd number: {0} isn't 5-digit number ", number3);
                Console.WriteLine("Please Try Again!");
                goto step3;
            }
        step4:
            Console.Write("Please enter 4th 3 digit number: ");
            string numberstr4 = Console.ReadLine();
            double number4 = Convert.ToDouble(numberstr4);
            Console.Clear();
            if (number4 >= 100 && number4 < 1000)
            {
                Console.WriteLine("The entered 4th number: {0} is 3-digit number", number4);

            }
            else
            {
                Console.WriteLine("The entered  4th number: {0} isn't 3-digit number ", number4);
                Console.WriteLine("Please Try Again!");
                goto step4;
            }
        step5:
            Console.Write("Please enter 5th 3 digit number: ");
            string numberstr5 = Console.ReadLine();
            double number5 = Convert.ToDouble(numberstr5);
            Console.Clear();
            if (number5 >= 100 && number5 < 1000)
            {
                Console.WriteLine("The entered 5th number: {0} is 3-digit number", number5);

            }
            else
            {
                Console.WriteLine("The entered  5th number: {0} isn't 3-digit number ", number5);
                Console.WriteLine("Please Try Again!");
                goto step5;
            }
            
            double sum1, sum2, Multiple;

            Console.WriteLine("Find 5% of all 5-digit values and MULTIPLY them");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
          
            number1 *= 0.05;
            number2 *= 0.05;
            number3 *= 0.05;
            Multiple = number1 * number2 * number3;
            Console.WriteLine($"5% of 5-digit values are: {number1}, {number2}, {number3} ");
            Console.WriteLine($"The Product of these 5-digit values is: {Multiple}");
            Console.WriteLine("Find 3% of all 3-digit values and SUM them");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            number4 *= 0.03;
            number5 *= 0.03;
            sum1 = number4 + number5;
            Console.WriteLine($"3% of 3-digit values are: {number4}, {number5}");
            Console.WriteLine($"The Total of these 3-digit values is: {sum1}");
            Console.WriteLine($"Find 10% of both Multiplication and Total. Finally Summarize them");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Multiple *= 0.1;
            sum1 *= 0.1;
            sum2 = Multiple + sum1;
            Console.WriteLine($"10% of both Multiplication and Total are as follows:{Multiple}, {sum1}.");
            Console.WriteLine($"The Sum of 10% of both Multiplication {Multiple} + Total {sum1} = {sum2}");
            Console.WriteLine("The answer is {0}", sum2);

            Console.ReadKey();
        }
    }
}
