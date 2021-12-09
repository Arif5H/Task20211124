using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*3-digit number is given.
         Type this value in the end of this value.
          Example: 333 = 333333;*/

        step1:
            Console.Write("Please enter 3-digit number: ");
            string numberstr = Console.ReadLine();
            int number = Convert.ToInt32(numberstr);
            Console.Clear();
            if (number >= 100 && number < 1000)
            {
                Console.WriteLine("The entered number: {0} is 3-digit number", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Type Value {number} in the end of this value {number} ");
                number = number * 1000 + number; 
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("The received value is: {0} ", number);
                Console.WriteLine("Please push any button to continue");
                Console.ReadKey();
                Console.Clear();
               
            }
            else
            {
                Console.WriteLine("The entered number: {0} isn't 3-digit number ", number);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
            


        }
    }
}
