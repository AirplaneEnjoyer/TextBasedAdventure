using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class SecondRoom : Room
    {
        public override void StartRoom()
        {
            bool loop = true;
            bool Axe = false;
            Choices choices = new Choices();
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Je staat nu in een grote ruimte met 5 deuren en 1 valluik.");
                Console.WriteLine("\n1. Probeer de gebroken deur.");
                Console.WriteLine("2. Probeer de gebarricadeerde deur.");
                Console.WriteLine("3. Ga door de deur met een sticker van een zwart gat er op.");
                Console.WriteLine("4. Probeer de saloon deur.");
                Console.WriteLine("5. Probeer de klaslokaal deur.");
                Console.WriteLine("6. Probeer de troll face valluik\n.");

                String actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                if (answer == 1)
                {

                    Console.Clear();


                    Console.WriteLine("Je Kijkt door een gat in de deur en je ziet er een bijl");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                }
                else if (answer == 2)
                {
                    Console.Clear();

                    if (!Axe)
                    {
                        Console.WriteLine("Je probeert de planken op de deur er af te halen, maar ze zitten te vast. " +
                            "Misschien kan een Bijl helpen.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Je hakt de planken er af en loopt door de deur met je bijl");
                        loop = false;
                    }
                }
                else if (answer == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Je opent de deur en je wordt spaghettified.");
                    Console.WriteLine("Je bent dood");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    choices.Main();
                }
                else if (answer == 4)
                {
                    Console.Clear();

                    Console.WriteLine("Je loopt de deur binnen en daar zitten een paar cowboys");
                    Console.WriteLine("\n1. Koop wat Alcohol");
                    Console.WriteLine("2. Praat met een cowboy");

                    string actionInput2 = Console.ReadLine();
                    int.TryParse(actionInput2, out int answer2);

                    if (answer2 == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("Je koopt wat alcohol en je wordt dronken en je blackt out.");
                        Console.WriteLine("Je wordt nooit meer wakker.");

                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        choices.Main();
                    }
                    else if (answer2 == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Je praat met een cowboy en hij verteld jou dat je de klaslokaal deur in moet voor de bijl.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                }
                else if (answer == 5)
                {
                    Console.Clear();

                    Console.WriteLine("Je loopt het klaslokaal binnen en daar zie je een boek op een tafel liggen. " +
                        "En er zit een gat in de muur die leidt naar de kamer met de gebroken deur waar een bijl is.");

                    Console.WriteLine("\n1. Pak het boek op en lees het.");
                    Console.WriteLine("2. Pak de bijl uit de andere kamer.");


                }
                    String actionInput3 = Console.ReadLine();
                    int.TryParse(actionInput3, out int answer3);
                    if (answer3 == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("Je pakt het boek op en je leest het en het zegt: "
                        + "Het zwarte figuur is niet wie je denkt, " +
                        "achter het masker schuilt wat je niet kent.");

                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                    else if (answer3 == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Je pakt de bijl uit de andere kamer" +
                                " en loopt weer terug naar de groote ruimte");

                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        Axe = true;
                    }
                else if (answer == 6)
                {
                    Console.Clear();

                    Console.WriteLine("Je opent het valluik en je ziet een middelfinger... wat grappig zeg");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
