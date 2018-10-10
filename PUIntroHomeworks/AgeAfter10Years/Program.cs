using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you ? :");
            int age = int.Parse(Console.ReadLine());
            int result = age + 10;
            Console.WriteLine($"You will be {result} years old after 10 years");
        }
    }
}
