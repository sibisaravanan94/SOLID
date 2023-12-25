﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version5
{
    internal class Swan : Bird, Flyable
    {
        public void fly()
        {
            Console.WriteLine("flap !!!");
        }
    }
}
