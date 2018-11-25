using System;
using System.Linq;

namespace TextBombardment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the sentcence you wish to bombard");
            string sentence = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter line width: ");
                int linewidth = int.Parse(Console.ReadLine());

                Console.WriteLine("To drop bombs input the numbers of the columns you wish to bombard (The bombs destroy the character they fall on + all the neighboring characters below it. Empty spaces below destroyed characters stop the bombs!): ");
                string bombIndexes = Console.ReadLine();
                int[] bombColumns = bombIndexes.Split(' ').Select(int.Parse).ToArray();  // Парсваме въведения стринг към масив от цели числа



                int lineCounter = 1;                            // Променлива, която ще брои на кой ред сме
                int rowEqualizer = 0;                           // Променлива, която, в проверката за бомбардирани индекси, ще приравни индексите на всеки символ в изречението така, че все едно са от първия ред на таблицата
                for (int i = 0; i < sentence.Length; i++)
                {
                    bool bombFlag=false;// Променлива, която ще индикира ако текущият индекс е сред бомбардираните




                    // Сравняваме всеки индекс от изречението с всеки от бомбардираните индекси и проверяваме дали под тях има празни пространства
                    for (int j = 0; j < bombColumns.Length; j++)
                    {
                        if (i-linewidth*rowEqualizer == bombColumns[j])// Без linewidth*rowEqualizer проверката ще важи само за символите от първия ред
                        {
                            //Ако под бомбардирания индекс има празно пространство премахваме текущия елемент от масива bombColumns[]  и така спираме съответната бомба
                            if (lineCounter > 1 && sentence[i] == ' ')
                            {
                                bombColumns = bombColumns.Except(new int[] { bombColumns[j] }).ToArray();
                            }
                            else
                            {
                                bombFlag = true;
                                break;
                            }
                        }
                    }



                    // Ако флага показва, че текущият индекс е сред бомбардираните вместо съответния символ се извежда празно пространство
                    if (bombFlag==false)
                    {
                        Console.Write(sentence[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    

                    
                    // linewidth*LineCounter за да открием индекса на последния символ, не само на първия, а на всеки един ред
                    // -1 Защото индексите започват да се броят от 0
                    if (i == linewidth * lineCounter - 1)
                    {
                        Console.WriteLine("\n");
                        lineCounter++;
                        rowEqualizer++;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");
        }
    }
}
