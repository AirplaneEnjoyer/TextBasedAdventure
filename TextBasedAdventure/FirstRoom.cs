using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class FirstRoom : Room
    {
        public override void StartRoom()
        {
            bool loop = true;
            bool key = false;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Je wordt wakker op de vloer in een kamer die je nog nooit heb gezien. Je staat op, wat doe je?");
                Console.WriteLine("\n1. Loop naar de deur.");
                Console.WriteLine("2. Open het nachtkastje.");
                Console.WriteLine("3. Examineer het raam.");
                Console.WriteLine("4. start de computer op\n.");

                string actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                if (answer == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Je loopt naar de deur en probeert het te openen.");
                    if (!key)
                    {
                        Console.WriteLine("De deur zit op slot en gaat niet open.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                    else
                    {
                        loop = false;
                    }
                }
                else if (answer == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Je opent het nachtkastje.");
                    if (!key)
                    {
                        Console.WriteLine("Er zit een sleutel in het nachtkastje die voor de deur is, je pakt de sleutel.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Er zit niks meer in het nachtkastje.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                }
                else if (answer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar het raam, het zit dicht vast gebakken. Buiten is een bos, en wanneer je dichterbij kijkt is daar een zwart figuur.");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
                else if (answer == 4)
                    {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de computer en start hem op, en op de computer staat: Zelda Ocarina of time open op de laatste boss." +
                                      "\nDe boss is één hit van dood. jij maakt de boss dood :)");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }


            }
        }


    }
}

