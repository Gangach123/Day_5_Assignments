using System;
namespace problems
{
    static class flipCoin
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the number: ");
            //VARIABLES
            int number = Convert.ToInt32(Console.ReadLine());
            string result = number % 2 == 0 ? "Number is even" : "Number is odd";
            Console.WriteLine(result);
        }
    }
}