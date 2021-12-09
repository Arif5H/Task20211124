using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
          /*5 Digit number is given.
          Please find 18% of given value. 
          Please find 3% of gotten new value.*/

        #region: !st Version
        step1:
            Console.Write("Please enter 5-digit number: ");
            string numberstr = Console.ReadLine();
            double number = Convert.ToDouble(numberstr);
            Console.Clear();
            if (number >= 10000 && number < 100000)
            {
                Console.WriteLine("The entered number: {0} is 5-digit number", number);
                Console.WriteLine($"Let's find 18% of the given number {number}");
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.18;
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Let's find 3% of the of the new received number {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.03;
                Console.WriteLine("The obtained number is {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 5-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            #endregion
            Console.Clear();

        /*5 Digit number is given.
      Please find 18% of given value. 
      Please find 3% of the 1st given value.*/
        step2:
            Console.WriteLine("CONDITION: 5 Digit number is given. Find 18 % of given value. Find 3 % of the 1st given value");
            Console.Write("Please enter 5-digit number: ");
            double number1;
            Console.Clear();
            if (number >= 10000 && number < 100000)
            {
                Console.WriteLine("The entered number: {0} is 5-digit number", number);
                Console.WriteLine($"Let's find 18% of the given number {number}");
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number *= 0.18;
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Let's find 3% of the of the new received number {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                number1 = number*0.03;
                Console.WriteLine("The obtained number is {0}", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 5-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step2;
            }





        }
    }
}
