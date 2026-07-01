using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class ThirdRoom : Room
    {
        private int _injured;
        public override void StartRoom()
        {
            bool loop = true;
            bool key = false;
            bool hammer = false;
            bool screwdriver = false;
            bool Axe = true;
            Choices choices = new Choices();
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Je staat in een gang gemaakt van kristallen");
                Console.WriteLine("\n1. Stomp op een kristal");
                Console.WriteLine("2. Kijk rond.");
                Console.WriteLine("3. Gebruik je bijl op de glazen doos");
                Console.WriteLine("4. Bekijk het schilderij op de grond");
                Console.WriteLine("5. Pak de schroevendraaier op");
                Console.WriteLine("6. Bekijk de kluis");
                Console.WriteLine("7. Probeer de deur te openen");

                String actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                if (answer == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Je stompt op een kristal en het kristal breekt en" +
                        " er komen kristal scherven in je voet.");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                    _injured++;
                }
                else if (answer == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Je kijkt rond en je ziet dat bijna alles gemaakt is van kristallen");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
                else if (answer == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Je loopt naar de glazen doos een breekt hem open met de bijl, " +
                        "maar de bijl breekt en je pakt de hamer");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    Axe = false;
                    hammer = true;
                }
                else if (answer == 4)
                {
                    Console.Clear();

                    Console.WriteLine("Je bekijkt het schilderij en op dat schilderij is een familie met het zwarte figuur");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
                else if (answer == 5)
                {
                    Console.Clear();

                    Console.WriteLine("Je pakt de schroevendraaier op van de grond");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    screwdriver = true;
                }
                else if (answer == 6)
                {
                    Console.Clear();

                    if (!screwdriver && !hammer)
                    {
                        Console.WriteLine("De kluis is gesloten, Misschien kan ik iets vinden om hem te openen");
                    }
                    else if (!screwdriver && hammer)
                    {
                        Console.WriteLine("Je slaat het slot er af met de hamer en daarin zit een doos die je kan open schroeven" +
                            " met een schroevendraaier");
                    }
                    else if (screwdriver && !hammer)
                    {
                        Console.WriteLine("Je kan nog niks met de schroevendraaier");
                    }
                    else if (screwdriver && hammer)
                    {
                        Console.WriteLine("Je slaat het slot er af met de hamer en schroeft de doos er in open en pakt de sleutel");
                        key = true;
                    }
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
                else if (answer == 7)
                {
                    Console.Clear();

                    if (!key)
                    {
                        Console.WriteLine("Je probeert de deur te openen maar hij zit op slot");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                    else if (key)
                    {
                        Console.WriteLine("Je gebruikt de sleutel op de deur");
                        if (_injured >= 1)
                        {
                            Console.WriteLine("Je opent de deur en wordt achtervolgd door het figuur, maar omdat " +
                                "je injured ben vangt hij jouw en ga je dood");
                            loop = false;
                        }
                        else
                        {
                            Console.WriteLine("Je opent de deur en wordt achtervolgd door het figuur. " +
                                "Je uitrent hem en loopt een deur uit en je bent vrij");
                            loop = false;
                        }
                    }
                }
            }
        }
    }
}

