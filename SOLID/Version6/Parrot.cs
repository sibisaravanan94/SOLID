using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version6
{
    internal class Parrot : Bird, Flyable
    {
        public void fly()
        {
            Console.WriteLine("flap !!!");
        }
    }
}
