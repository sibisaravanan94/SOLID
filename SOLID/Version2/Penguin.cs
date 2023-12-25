using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version2
{
    internal class Penguin : Bird
    {
        // smell bad code
        // Penguin can't fly but we are foring the subtype to implement the behavior
        public override void fly()
        {
            throw new NotImplementedException();
        }
    }
}
