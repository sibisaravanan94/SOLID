using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version5
{
    internal class Eagle : Bird, Flyable
    {
        public void fly()
        {
            Console.WriteLine("glid !!!");
        }
    }
}
