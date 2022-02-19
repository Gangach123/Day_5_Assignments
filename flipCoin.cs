using System;
namespace problems
{
    static class flipCoin
    {
        static void Main(string[] args)
        {
            int HEAD = 0;
            int TAIL = 0;
            int value = 0;
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            
            while(value<a)
            {
                Random randomNumber = new Random();
                double number = randomNumber.NextDouble();
                Console.WriteLine(number);
                if (number > 0.5)
                {
                    HEAD++;
                }
                else
                {
                    TAIL++;
                }
                value++;
            }
            Console.WriteLine($"Percentage of head is {(TAIL * 100) /a}");
            Console.WriteLine($"Percentage of head is {(HEAD * 100) / a}");
        }
    }
}
