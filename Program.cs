using System;
namespace problems
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            double s = 0.0;

            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("Sum of Series upto {0} terms : {1} ", n, s);

        }
    }
}