using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal // Reptile is the Derived class (child) of Animal(parent)
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public string ScaleColors { get; set; }
        public bool LimbRegeneration {  get; set; }
        public double TempRequirement { get; set; }
        public bool IsVenomous { get; set; }

        public void PrintReptile()
        {
            Console.WriteLine($"| Venomous:\t\t{IsVenomous}\n| Limb Regeneration:\t{LimbRegeneration}\n| Body Colors:\t\t{ScaleColors}\n| Basking Temperature:\t{TempRequirement} F\u00B0");
        }
    }
}
