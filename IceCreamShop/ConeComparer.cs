using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare([AllowNull] Cone x, [AllowNull] Cone y)
        {
            return x.Cost.CompareTo(y.Cost);
        }
    }
}
