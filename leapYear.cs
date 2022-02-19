using System;
namespace leap_Year
{
    class LeapYear
    {
        static void Main()
        {
            
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Entered year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Entered year is not a Leap Year");
            }
        }
    }
}
