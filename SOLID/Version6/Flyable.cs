using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version6
{
    // Breaking single responsibility, Liskov substitution and interface segrigation
    // fat/ bulk interface
    // it doesn't say SAM
    // high cohesion and low coupling
    internal interface Flyable
    {
        void fly();
    }
}
