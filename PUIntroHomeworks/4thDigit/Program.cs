using System;

namespace _4thDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 7-digit number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000000 || number > 9999999)
            {
                Console.WriteLine("The number you entered is not a 7-digit number!");
            }
            else
            {
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;

                Console.WriteLine($"The 4th digit of {number} is {fourthDigit}");
            }
        }
    }
}
