using System;

namespace MyUniqueNumber
{
    class Program
    {
        static int AgeAfter10Years(int currentAge)
        {
            int ageAfter10Years = currentAge + 10;

            return ageAfter10Years;
        }
        static double MyUniqueNumber(int ageAfter10Years, int last4DigitsOfFacNumber)
        {
            double MyUniqueNumber = ageAfter10Years * last4DigitsOfFacNumber;

            return MyUniqueNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int Last4Digits = int.Parse(Console.ReadLine());
            double result = MyUniqueNumber(AgeAfter10Years(age), Last4Digits);
            Console.WriteLine("After 10 years you'll be " + AgeAfter10Years(age) + " years old. "
                + "And your unique number is: " + result);
        }
    }
}
