using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
        /*6 dene 6 reqemli eded verilib. Evvel hamisini topla .
         * Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
            I neticeden II neticeni cix. Alinan cavabin 10% tap. 
            Neticenin uzerine V ve VI ededleri gel.
            Yekunda alinan cavabin 11% tap.
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
        step5:
            Console.Write("Please enter 5th 6 digit number: ");
            string numberstr5 = Console.ReadLine();
            double number5 = Convert.ToDouble(numberstr5);
            Console.Clear();
            if (number5 >= 100000 && number5 < 1000000)
            {
                Console.WriteLine("The entered 5th number: {0} is 6-digit number", number5);

            }
            else
            {
                Console.WriteLine("The entered  5th number: {0} isn't 6-digit number ", number5);
                Console.WriteLine("Please Try Again!");
                goto step5;
            }
        step6:
            Console.Write("Please enter 6th 6 digit number: ");
            string numberstr6 = Console.ReadLine();
            double number6 = Convert.ToDouble(numberstr6);
            Console.Clear();
            if (number5 >= 100000 && number5 < 1000000)
            {
                Console.WriteLine("The entered 6th number: {0} is 6-digit number", number6);

            }
            else
            {
                Console.WriteLine("The entered  6th number: {0} isn't 6-digit number ", number6);
                Console.WriteLine("Please Try Again!");
                goto step6;
            }

            double Total, deduct, Total1;
            Console.WriteLine("Find Total of all 6-digit numbers");
            Total = number1 + number2 + number3 + number4 + number5 + number6;
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Console.WriteLine("The Total of all 6-digit numbers is {0}", Total);
            Console.WriteLine($"Type in the end of 1st number {number1} the value of 3rd number {number3}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            number1 *= 1000000;
            number1 += number3;
            Console.WriteLine($"The found new Typed value is {number1}");
            Console.WriteLine("Deduct from 1 st result the 2nd result. And find 10% of the deduction");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            deduct = Total - number1;
            Console.WriteLine("The deduction is {0}", deduct);
            deduct *= 0.1;
            Console.WriteLine($"10% of deduction is {deduct}");
            Console.WriteLine($"Add 5th and 6th number to the last received Result {deduct}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Total1 = deduct + number5 + number6;
            Console.WriteLine($"The result is {Total1}");
            Console.WriteLine($"Find 11% of the final result {Total1}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Total1 *= 0.11;
            Console.WriteLine($"The 11% of the final result is {Total1}");
            

            Console.ReadKey();
        }
    }
}
