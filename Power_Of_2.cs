using System;
namespace power_Of_2
{
    static class Power_Of_2
    {
        static void Main()
        {
            
            Console.WriteLine("Enter a value for 2:");
            int value = Convert.ToInt32(Console.ReadLine());
            
           for (int i=1;i<=value;i++)
            {
                double powerOf = Math.Pow(2, i);
                Console.WriteLine(powerOf);
                
            }
           Console.ReadLine();
        }
    }
}