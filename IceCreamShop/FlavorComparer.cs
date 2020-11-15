using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        public int Compare([AllowNull] Flavor x, [AllowNull] Flavor y)
        {
            int result = x.Allergens.Count.CompareTo(y.Allergens.Count);
            return result != 0 ? result : x.Name.CompareTo(y.Name); 
        }
    }
}
