using System;

namespace GetMax
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int number1=0, number2=0, number3=0;
            Console.WriteLine("Hello user! Please enter 3 integers and I will tell you which one is the biggest.");
            Console.WriteLine(GetTheMax(number1,number2,number3));
        }



        public static int GetTheMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Enter first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                return (firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                return (secondNumber);
            }
            else
            {
                return (thirdNumber);
            }
        }
    }
}
