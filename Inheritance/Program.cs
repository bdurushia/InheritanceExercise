using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var turkeyVulture = new Bird()
            {
                Name = "Turkey Vulture",
                ScientificName = "Cathartes Aura",
                AverageAge = 20,
                MovementType = "Flight & can walk",
                Weight = 3.3,
                CanFly = true,
                WingSpanInches = 67.5,
                FeathersStyle = "Two-Toned, Brown on top, white underneath",
                BeakStyle = "Short, hooked, ivory-colored"

            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var gilaMonster = new Reptile()
            {
                Name = "Gila Monster",
                ScientificName = "Helodermatidae",
                AverageAge = 25,
                MovementType = "Walks on 4 Legs",
                Weight = 1.48,
                IsVenomous = true,
                LimbRegeneration = false,
                ScaleColors = "Black & Yellow or Pink",
                TempRequirement = 87

            };


            Console.WriteLine("\n\n______________________________________________________________________");
            Console.WriteLine("============================== ANIMALS ===============================");

            Console.WriteLine("\n======================================================================\n");

            turkeyVulture.PrintAnimal();
            turkeyVulture.PrintBird();

            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("\n======================================================================\n");

            gilaMonster.PrintAnimal();
            gilaMonster.PrintReptile();

            Console.WriteLine("______________________________________________________________________");
        }
    }
}
