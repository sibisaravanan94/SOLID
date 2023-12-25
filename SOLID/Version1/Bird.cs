using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version1
{
    internal class Bird
    {
        public string Name { get; set; }
        public BirdType birdType { get; set; }
        public int weight { get; set; }
        public BirdSize size { get; set; }

        public void fly()
        {
            Console.WriteLine("flap !!!");
        }

        public void eat()
        {
            Console.WriteLine("Yummy !!!");
        }

        public void sleep()
        {
            Console.WriteLine("Zzzzzz !!!");
        }

        public void fight()
        {
            Console.WriteLine("WTF !!!");
        }
    }

    internal enum BirdSize
    {
        small,
        medium,
        large
    }

    internal enum BirdType
    {
        Egle,
        sparrow,
        parrot
    }
}
