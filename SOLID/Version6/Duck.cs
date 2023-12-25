using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version6
{
    
    internal class Duck : Bird, Flyable, Swimmable
    {
        public void fly()
        {
            Console.WriteLine("flap !!!");
        }

        public void swim()
        {
            Console.WriteLine("swim !!!");
        }
    }
}
