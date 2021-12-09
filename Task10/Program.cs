using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
        /*3 dene 4 reqemli eded verilib. 
         * I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
           Neticeleri bir birinden cix.
           Alinan cavabin ustune III ededin 7% faizini gel
         */
        step1:
            Console.Write("Please enter 1st 4 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);

            Console.Clear();

        step2:
            Console.Write("Please enter 2nd 4 digit number: ");
            string numberstr2 = Console.ReadLine();
            double number2 = Convert.ToDouble(numberstr2);
            Console.Clear();
        step3:
            Console.Write("Please enter 3rd 4 digit number: ");
            string numberstr3 = Console.ReadLine();
            double number3 = Convert.ToDouble(numberstr3);
            Console.Clear();
            double deduction;
            double Sum;

            if (number1 >= 1000 && number1 < 10000)
            {
                Console.WriteLine("The entered 1st number: {0} is 4-digit number", number1);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                if (number2 >= 1000 && number2 < 10000)
                {
                    Console.WriteLine("The entered 2nd number: {0} is 4-digit number", number2);
                    Console.WriteLine("Please push any button to continue");
                    if (number3 >= 1000 && number3 < 10000)
                    {
                        Console.WriteLine("The entered 3rd number: {0} is 4-digit number", number3);
                        Console.WriteLine($"Find 1% of 1st 4-digit number {number1}");
                        Console.WriteLine($"Find 2% of 2nd 4-digit number {number2}");
                        Console.WriteLine($"Find 3% of 3rd 4-digit number {number3}");
                        Console.WriteLine("Please push any button to continue");
                        Console.ReadKey();
                        Console.Clear();
                        number1 *= 0.01;
                        number2 *= 0.02;
                        number3 *= 0.03;
                        Console.WriteLine($"1% of 1st 4-digit number is: {number1}");
                        Console.WriteLine($"2% of 2nd 4-digit number is: {number2}");
                        Console.WriteLine($"3% of 3rd 4-digit number is: {number3}");
                        Console.WriteLine($"Deduct the numbers: {number1} - {number2} - {number3}");
                        Console.WriteLine("Please push any button to continue");
                        Console.ReadKey();
                        Console.Clear();
                        deduction = number1 - number2 - number3;
                        Console.WriteLine($"The deducted value of numbers is: {number1} - {number2} - {number3} = {deduction}");
                        Console.WriteLine($"Add 7% of Number3 {number3} to Deducted value {deduction}");
                        Console.WriteLine("Please push any button to continue");
                        Console.ReadKey();
                        Console.Clear();
                        double number4 = number3 * 0.07;
                        Sum = number4 + deduction;
                        Console.WriteLine($"7% of 3rd number is {number4}");
                        Console.WriteLine($"Sum of 7% of 3rd number and the deducted value is {number4} + {deduction} ={Sum}");
                        Console.WriteLine("Please push any button to continue");
                        
                       
                    }
                    else
                    {
                        Console.WriteLine("The entered 3rd number: {0} isn't 4-digit number ", number3);
                        Console.WriteLine("Please Try Again!");
                        goto step3;
                    }
                }
                else
                {
                    Console.WriteLine("The entered 2nd number: {0} isn't 4-digit number ", number2);
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
           
            Console.ReadKey();

        }
    }
}
