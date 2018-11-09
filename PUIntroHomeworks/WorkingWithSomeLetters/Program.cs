using System;
using System.Text;

namespace WorkingWithSomeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            Console.OutputEncoding = Encoding.UTF8;

      
            string[] stringArray = new string[100];

            Console.WriteLine("Даден е низ от 100 случайни букви на кирилица. Програмата показва кои гласни са широки, тесни и съставни, както и кои съгласни са звучни, беззвучни и сонорни.");
            Console.WriteLine("-------------------------------------------------------");

            for (int i = 0; i < 100; i++)
            {
                stringArray[i] = ((char)rand.Next(1072, 1103)).ToString();
                Console.Write(stringArray[i]);
            }

            Console.WriteLine("\n-------------------------------------------------------");

           
            for (int i = 0; i < 100; i++)
            {
                if ((stringArray[i] == "а") || (stringArray[i] == "o") || (stringArray[i] == "е"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е широка гласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "и") || (stringArray[i] == "у") || (stringArray[i] == "ъ"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) e тясна гласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "ю") || (stringArray[i] == "я"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е съставна гласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "п") || (stringArray[i] == "ф") || (stringArray[i] == "к") || (stringArray[i] == "т") || (stringArray[i] == "ш") || (stringArray[i] == "с") || (stringArray[i] == "x") || (stringArray[i] == "ц"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е беззвучна съгласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "л") || (stringArray[i] == "м") || (stringArray[i] == "н") || (stringArray[i] == "р"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е сонорна съгласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "б") || (stringArray[i] == "в") || (stringArray[i] == "г") || (stringArray[i] == "д") || (stringArray[i] == "ж") || (stringArray[i] == "з") || (stringArray[i] == "ч"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е звучна съгласна и се намира под номер {i}.");
                }
            }
        }
    }
}
