using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal // Bird is the Derived class (child) of Animal (parent)
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public string FeathersStyle { get; set; }
        public string BeakStyle { get; set; }
        public double WingSpanInches { get; set; }
        public bool CanFly { get; set; }

        public void PrintBird()
        {
            Console.WriteLine($"| Can Fly:\t\t{CanFly}\n| Average Wing Span:\t{WingSpanInches} inches\n| Feather Colors:\t{FeathersStyle}\n| Beak Style:\t\t{BeakStyle}");
        }
    }
}
