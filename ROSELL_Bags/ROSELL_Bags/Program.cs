using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSELL_Bags
{
    internal class Bags
    {
        static void Main(string[] args)
        {
            

            Console.Write("Number of Bags Ordered: ");
            int numBags = Convert.ToInt32(Console.ReadLine());

            int numLargeBoxes = numBags / 20;
            
            int numMediumBoxes = (numBags % 20) / 10;

            int numSmallBoxes = (numBags % 10 + 4) / 5;


            double totalCost = numLargeBoxes * 3 +
                               numMediumBoxes * 2.5 +
                               numSmallBoxes * 2 +
                               numBags * 5.5;

            Console.WriteLine("Boxes Used:");
            Console.WriteLine($"Large - {numLargeBoxes}");
            Console.WriteLine($"Medium - {numMediumBoxes}");
            Console.WriteLine($"Small - {numSmallBoxes}");
            Console.WriteLine($"Your total cost is: ${totalCost:F2}");
        }
    }
}
