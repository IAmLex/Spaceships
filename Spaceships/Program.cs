using System;
using System.Collections.Generic;

namespace Spaceships
{
    class Program
    {
        public static List<Fighter> fighters;
        public static List<Cargoship> cargoships;
        static void Main(string[] args)
        {
            fighters = new List<Fighter>
            {
                new Fighter("My first fighter", 200, 10, 10),
                new Fighter("My second fighter", 500, 2, 35),
                new Fighter("My third fighter", 200, 25, 3),
            };

            cargoships = new List<Cargoship>
            {
                new Cargoship("My first cargoship")
            };

            string command = "";
            while (command.ToUpper() != "EXIT")
            {
                Console.Write("Command > ");
                command = Console.ReadLine();

                if (command.ToUpper() == "SHOOT")
                {
                    Shoot();
                }
                else if (command.ToUpper() == "LIST")
                {
                    PrintFighters();
                    printCargoships();
                }
                else if (command.ToUpper() == "CLS" || command.ToUpper() == "CLEAR")
                {
                    Clear();
                }
                else
                {
                    Console.WriteLine("Unknown command!");
                }
            }
        }

        public static void Shoot()
        {
            Console.WriteLine("Only fighter ships can shoot and be shot");

            PrintFighters();

            int selection1 = GetInputInt(1, fighters.Count);

            Spaceship selection1S = fighters[selection1];

            if (fighters[selection1].IsDead())
                return;

            PrintFighters();

            int selection2 = GetInputInt(1, fighters.Count);

            if (fighters[selection2].IsDead())
                return;

            Random rnd = new Random();
            
            int num = rnd.Next(0, 11);
            if (fighters[selection2].accuracy > num)
            {
                fighters[selection2].GetHit(fighters[selection1].Shoot());
                Console.WriteLine($"{fighters[selection1].name} hits it's shot ({fighters[selection1].Shoot()}) {fighters[selection2].name} has {fighters[selection2].health} health left.");
            }
            else
            {
                Console.WriteLine($"{fighters[selection1].name} misses it's shot.");
            }
        }

        public static int GetInputInt(int min, int max, string message = "Choose a spaceship > ")
        {
            string input;
            int output;

            bool correct = false;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (Int32.TryParse(input, out output))
                    if (output >= min && output <= max)
                        correct = true;
            } while (!correct);

            return output - 1;
        }

        public static void PrintFighters()
        {
            int count = 0;
            Console.WriteLine("Fighters:");
            foreach (Fighter fighter in fighters)
            {
                count++;
                Console.WriteLine($"{count}: {fighter.name} ({fighter.health})");
            }
        }

        public static void printCargoships()
        {
            int count = 0;
            Console.WriteLine("Cargoships:");
            foreach (Cargoship cargoship in cargoships)
            {
                Console.WriteLine($"{count}: {cargoship.name} ({cargoship.health})");
                count++;
            }
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
