using System;

namespace WorkingWithSomeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] intArray = new int[100];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rand.Next(132);
            }

            Console.WriteLine("Here are 100 random genereted numbers");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"{intArray[i]}");
            }

            Console.WriteLine("Choose what you want to do with them (type in the letter): ");
            Console.WriteLine("a) Display the numbers that have even indexes.");
            Console.WriteLine("b) Display the numbers that are odd and have odd indexes.");
            Console.WriteLine("c) Display the numbers that are divided by 3 without a remainder.");
            Console.WriteLine("d) Display the numbers that are divided by 7 and have 1 as remainder.");
            Console.WriteLine("e) Display the numbers that are in the interval between 26 and 100.");
            Console.WriteLine("f) Display the numbers that are not in the interval between 26 and 100.");
            Console.WriteLine("----------------------------------------------------------");
            
            char option = char.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------");

            switch (option)
            {
                case 'a':
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        if(i%2==0)
                        {
                            Console.WriteLine($"{intArray[i]} has index {i}");
                        }
                    }
                    break;
                case 'b':
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        if(intArray[i]%2!=0&&i%2!=0)
                        {
                            Console.WriteLine($"{intArray[i]} is odd and its index is {i}");
                        }
                    }
                    break;
                case 'c':
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        if(intArray[i]%3==0)
                        {
                            Console.WriteLine($"{intArray[i]} is divided by 3 without a remainder");
                        }
                    }
                    break;
                case 'd':
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        if (intArray[i] % 7 == 1)
                        {
                            Console.WriteLine($"{intArray[i]} is divided by 7 with a remainder of 1");
                        }
                    }
                    break;
                case 'e':
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        if(intArray[i]>=26&&intArray[i]<=100)
                        {
                            Console.WriteLine($"{intArray[i]} is between 26 and 100");
                        }
                    }
                    break;
                case 'f':
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        if (intArray[i] < 26 || intArray[i] > 100)
                        {
                            Console.WriteLine($"{intArray[i]} is not between 26 and 100");
                        }
                    }
                    break;
                default: Console.WriteLine("Incorrect option!");
                    break;
            }
        }
    }
}
