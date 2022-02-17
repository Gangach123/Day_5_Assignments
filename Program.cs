using System;
namespace problems
{
     class Program
    {
        static void Main(string[] args)
        {
            char firststring;
            Console.WriteLine("Enter any character: ");
            firststring = Convert.ToChar(Console.ReadLine());


            //Checking for vowel
            if (firststring == 'a' || firststring == 'e' || firststring == 'i' || firststring == 'o' || firststring == 'u' || firststring == 'A' || firststring == 'E' || firststring == 'I' || firststring == 'O' || firststring == 'U')
            {

                Console.WriteLine($"Entered character is a vowel: {firststring} ");

            }
            else
            {
                Console.WriteLine($"Entered character is a consonant: {firststring} ");
            }
            Console.ReadLine();

        }
    }
}