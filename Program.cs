using System;


namespace swapcase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the first number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
           
            int Quotient = firstNumber / secondNumber;
            int Reminder = firstNumber % secondNumber;

            Console.WriteLine($"The quotient value : {Quotient} and the reminder value:{Reminder}");
        }
    }
}