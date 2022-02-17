using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeFactors
{
    class Program
    {
        static void Main()
        {
            //For entering number
            Console.WriteLine("Please enter your number: ");
            int a = int.Parse(Console.ReadLine());

            int num = a;

            //Inintializing the factor value i with one
            int fact = 1;

            //To store the prime factors in empty list
            string primeString = "";

            while (++fact <= num)
            {
                //If the factor devides the number add the factor to the empty list
                primeString += (num % fact == 0) ? " " + fact : "";

                //Devide out the test factor until you are unable to do so
                while (num % fact == 0) num /= fact;
            }
            Console.WriteLine("Factors of " + a + " are" + primeString);
        }
    }
}