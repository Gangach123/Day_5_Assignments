using System;


namespace swapcase
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the string of A: ");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the string of b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Swapped numbers: {a} : {b}");
        }
    }
}