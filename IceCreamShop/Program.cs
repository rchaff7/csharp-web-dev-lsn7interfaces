using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            //FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(new FlavorComparer());
            Console.WriteLine("Flavors sorted by number of Allergens, then Name:");
            foreach (var item in availableFlavors)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----");

            availableCones.Sort(new ConeComparer());
            Console.WriteLine("Cones sorted by price:");
            foreach (var item in availableCones)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----");
        }
    }
}
