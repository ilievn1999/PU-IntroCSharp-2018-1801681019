using System;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticket=100000,luckyTickets=0,normalTickets=0,totalTickets=0;
            int firstDigit, secondDigit, thirdDigit, fourthDigit, fifthDigit, sixthDigit;
            Console.WriteLine("The lucky tickets are:");
            while (ticket<1000000)
            {
                firstDigit = ticket / 100000;
                secondDigit = ticket % 100000 / 10000;
                thirdDigit = ticket % 10000 / 1000;
                fourthDigit = ticket % 1000 / 100;
                fifthDigit = ticket % 100 / 10;
                sixthDigit = ticket % 10;
                if (firstDigit + secondDigit + thirdDigit == fourthDigit + fifthDigit + sixthDigit)
                {
                    Console.WriteLine(ticket);
                    luckyTickets = luckyTickets + 1;
                }
                else
                {
                    normalTickets = normalTickets + 1;
                }
                ticket = ticket + 1;
                totalTickets = totalTickets + 1;
            }
            Console.WriteLine($"There are {luckyTickets} lucky tickets");
            Console.WriteLine($"There are {normalTickets} not lucky tickets");
            Console.WriteLine($"Total tickets existing are {totalTickets}");
        }
    }
}
