using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
        /*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            Sonra alinan cavabin ustune gel 6 reqemli ededi.
            Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
            Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
         */
        step1:
            Console.Write("Please enter 1st 3 digit number: ");
            string numberstr1 = Console.ReadLine();
            double number1 = Convert.ToDouble(numberstr1);
            Console.Clear();
            if (number1 >= 100 && number1 < 1000)
            {
                Console.WriteLine("The entered 1st number: {0} is 3-digit number", number1);

            }
            else
            {
                Console.WriteLine("The entered  1st number: {0} isn't 3-digit number ", number1);
                Console.WriteLine("Please Try Again!");
                goto step1;
            }
        step2:
            Console.Write("Please enter 2nd 3 digit number: ");
            string numberstr2 = Console.ReadLine();
            double number2 = Convert.ToDouble(numberstr2);
            Console.Clear();
            if (number2 >= 100 && number2 < 1000)
            {
                Console.WriteLine("The entered 2nd number: {0} is 3-digit number", number2);

            }
            else
            {
                Console.WriteLine("The entered  2nd number: {0} isn't 3-digit number ", number2);
                Console.WriteLine("Please Try Again!");
                goto step2;
            }
        step3:
            Console.Write("Please enter 3rd 4 digit number: ");
            string numberstr3 = Console.ReadLine();
            double number3 = Convert.ToDouble(numberstr3);
            Console.Clear();
            if (number3 >= 1000 && number3 < 10000)
            {
                Console.WriteLine("The entered 3rd number: {0} is 4-digit number", number3);


            }
            else
            {
                Console.WriteLine("The entered  3rd number: {0} isn't 4-digit number ", number3);
                Console.WriteLine("Please Try Again!");
                goto step3;
            }
        step4:
            Console.Write("Please enter 4th 4 digit number: ");
            string numberstr4 = Console.ReadLine();
            double number4 = Convert.ToDouble(numberstr4);
            Console.Clear();
            if (number4 >= 1000 && number4 < 10000)
            {
                Console.WriteLine("The entered 4th number: {0} is 4-digit number", number4);

            }
            else
            {
                Console.WriteLine("The entered  4th number: {0} isn't 4-digit number ", number4);
                Console.WriteLine("Please Try Again!");
                goto step4;
            }
        step5:
            Console.Write("Please enter 5th 5-digit number: ");
            string numberstr5 = Console.ReadLine();
            double number5 = Convert.ToDouble(numberstr5);
            Console.Clear();
            if (number5 >= 10000 && number5 < 100000)
            {
                Console.WriteLine("The entered 5th number: {0} is 5-digit number", number5);

            }
            else
            {
                Console.WriteLine("The entered  5th number: {0} isn't 5-digit number ", number5);
                Console.WriteLine("Please Try Again!");
                goto step5;
            }
        step6:
            Console.Write("Please enter 6th 5 digit number: ");
            string numberstr6 = Console.ReadLine();
            double number6 = Convert.ToDouble(numberstr6);
            Console.Clear();
            if (number6 >= 10000 && number6 < 100000)
            {
                Console.WriteLine("The entered 6th number: {0} is 5-digit number", number6);

            }
            else
            {
                Console.WriteLine("The entered  6th number: {0} isn't 5-digit number ", number6);
                Console.WriteLine("Please Try Again!");
                goto step6;
            }
        step7:
            Console.Write("Please enter 7th 6 digit number: ");
            string numberstr7 = Console.ReadLine();
            double number7 = Convert.ToDouble(numberstr7);
            Console.Clear();
            if (number7 >= 100000 && number7 < 1000000)
            {
                Console.WriteLine("The entered 7th number: {0} is 6-digit number", number7);

            }
            else
            {
                Console.WriteLine("The entered  7th number: {0} isn't 6-digit number ", number7);
                Console.WriteLine("Please Try Again!");
                goto step7;
            }

            double Totalof3digitnumbers, Productof4digitnumbers, Total1, Totalof5digitNumbers, Final, Productof3digitNumbers,deduct,Total2;

            Console.WriteLine("Find Total of all 3-digit numbers");
            Totalof3digitnumbers = number1 + number2;
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Console.WriteLine("The Total of all 3-digit numbers is {0}", Totalof3digitnumbers);
            Console.WriteLine("Find Product of all 4-digit numbers");
            Productof4digitnumbers = number3 * number4;
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Console.WriteLine($"The Product of all 4-digit numbers {number3} and {number4} is {Productof4digitnumbers}");
            Console.WriteLine($"Find The TOTAL of Sum of 3-digit numbers{Totalof3digitnumbers} and Product of 4-digit numbers{Productof4digitnumbers}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Total1 = Totalof3digitnumbers + Productof4digitnumbers;
            Console.WriteLine($"The TOTAL of Sum of 3-digit numbers {Totalof3digitnumbers}and Product of 4-digit numbers{Productof4digitnumbers} is {Total1}");
            Console.WriteLine($"Type digit 7 in the end of received Total {Total1}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            
            Total1 = Total1 * 10 + 7;
            Console.WriteLine($"The new received value is {Total1}");
            Console.WriteLine($"Find TOTAL of 5-digit numbers");
            Totalof5digitNumbers = number5 + number6;
            Console.WriteLine("Pleasea push any button");
            Console.ReadKey();
            Console.WriteLine($"TOTAL of 5-digit numbers is {Totalof5digitNumbers}");
            Console.WriteLine($"Add to the new received value {Total1} the Sum of 5-digit{Totalof5digitNumbers} numbers");
            Total1 += Totalof5digitNumbers;
            Console.WriteLine($"The last obtained Total is {Total1}");
            Console.WriteLine("Pleasea push any button");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Let's find the product of originally given 3-digit Numbers {number1}*{number2}");
            Productof3digitNumbers = number1 * number2;
            Console.WriteLine("Pleasea push any button");
            Console.ReadKey();
            Console.WriteLine($"Product of all 3-digit numbers is {Productof3digitNumbers}");
            Console.WriteLine($"Type digit 1 in the ond of Product of all 3-digit numbers{Productof3digitNumbers}");
            Console.WriteLine("Pleasea push any button");
            Console.ReadKey();
            Productof3digitNumbers = Productof3digitNumbers * 10 + 1;
            Console.WriteLine($"The Last received value of product of all 3-digit numbers with typed 1 in the end is {Productof3digitNumbers}");

            Console.WriteLine($"Deduct from last obtained Total {Total1} the product of 3-digit numbers with additionally typed digit 1 in the end of product");
            Console.WriteLine("Pleasea push any button");
            Console.ReadKey();
            deduct = Total1 - Productof3digitNumbers;
            Console.WriteLine($"The obtained new deduction value is {deduct}");
        
            Console.WriteLine($"Find Sum of deducted number{deduct} and original 6-digit number{number7}");
            Total2 = deduct + number7;
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Console.WriteLine($"The SUM of deducted number{deduct} and original 6-digit number{number7} is {Total2}");
            Console.WriteLine($"Deduct from the last SUM {Total2} the sum of 3&4-digit numbers");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            deduct = Total2 - number1 - number2 - number3 - number4;
            Console.WriteLine($"The deduction is {deduct}");
            Console.WriteLine($"Find 18% of last obtained value {deduct}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            deduct *= 0.18;
            Console.WriteLine($"The received value is {deduct}");
            Console.WriteLine($"Find 3% of last obtained value {deduct}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            deduct *= 0.03;
            Console.WriteLine($"The received value is {deduct}");
            Console.WriteLine($"Find 1% of last obtained value {deduct}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            deduct *= 0.01;
            Console.WriteLine($"The received value is {deduct}");
            Console.WriteLine($"Add The total 5-digitnumbers {Totalof5digitNumbers} to The Reseived Final Value {deduct}");
            Console.WriteLine("Please push any button");
            Console.ReadKey();
            Final = Totalof5digitNumbers + deduct;
            Console.WriteLine($"The final answer is {Final}");

            Console.ReadKey();
        }
    }
}
