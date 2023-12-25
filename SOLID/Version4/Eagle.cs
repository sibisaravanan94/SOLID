using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version4
{
    internal class Eagle : FlyableBird
    {
        public override void fly()
        {
            Console.WriteLine("glid !!!");
        }
    }
}
