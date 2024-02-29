using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal // Base Class (Parent)
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common

        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string MovementType { get; set; }
        public double AverageAge { get; set; }
        public double Weight { get; set; }

        public void PrintAnimal()
        {
            Console.WriteLine($"| Name:\t\t\t{Name}\n| Scientific Name:\t{ScientificName}\n| Average Age:\t\t{AverageAge} Years\n| Movement:\t\t{MovementType}\n| Average Weight:\t{Weight}lbs.");
        }
    }
}
