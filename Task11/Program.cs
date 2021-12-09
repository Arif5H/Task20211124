using System;

namespace Task11
{
    class Program
    {   
        static void Main(string[] args)
        {
        /* 4 dene 5 reqemli eded verilib.
         * Her I ededin ustune III ededi gel .
         * II ededin usutune IV eeddi gel. 
            Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.
         */
        step1:
            Console.Write("Please enter 1st 5 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);
            Console.Clear();
            if (number1 >= 10000 && number1 < 100000)
            { Console.WriteLine("The entered 1st number: {0} is 5-digit number", number1);
               
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
            Console.Write("Please enter 4th 5 digit number: ");
            string numberstr4 = Console.ReadLine();
            double number4 = Convert.ToDouble(numberstr4);
            Console.Clear();
            if (number4 >= 10000 && number4 < 100000)
            {
                Console.WriteLine("The entered 4th number: {0} is 5-digit number", number4);
                
                
            }
            else
            {
                Console.WriteLine("The entered  4th number: {0} isn't 5-digit number ", number4);
                Console.WriteLine("Please Try Again!");
                goto step4;
            }
            double number5;
            double number6; 
            double deduction;
            double Multiple;

            Console.WriteLine($"Add 3rd number {number3} to each of these numbers");
                Console.WriteLine("Please push any button to continue");
            Console.ReadKey();
            Console.Clear();
            number5 = number2 + number4;
            number6 = number3 * 0.03;
            number1 += number3;
            number2 += number3;
            number3 += number3;
            number4 += number4;
            Console.WriteLine($"The received values are: {number1}, {numberstr2}, {number3}, {number4}");
            Console.WriteLine("Add original values of 2nd and 4th numbers");
            Console.WriteLine("Please push any button to continue");
            Console.ReadKey();
            Console.WriteLine("The received value is {0}", number5);
            Console.WriteLine($"Multiple all received values {number1}*{number2}*{number3}*{number4}*{number5}");
            Multiple = number1 * number2 * number3 * number4 * number5;
            Console.WriteLine("Please push any button to continue");
            Console.ReadKey();
            Console.WriteLine($"Deduct the last Multiplication value {Multiple} from 3% of original value of 3rd number {number3}");
            deduction = Multiple - number6;
            Console.WriteLine($"The Deducted value is equal to {deduction}");
            Console.ReadKey();

        }
    }
}
