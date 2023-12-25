using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version4
{
    // Never ever bring behavior to hierarchy
    internal abstract class FlyableBird : Bird
    {
        public abstract void fly();
    }
}
