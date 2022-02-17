using System;


namespace largestNumber
{
    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the first number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the first number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"The largest number is: {firstNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"The largest number is: {secondNumber}");
            }
            else
            {
                Console.WriteLine($"The largest number is:  {thirdNumber}");
            }

        }
    }
}