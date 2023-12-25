using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version6
{
    internal class Penguin : Bird, Swimmable
    {
        public void swim()
        {
            Console.WriteLine("swim !!!");
        }
    }
}
