using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Version6
{
    internal abstract class Bird
    {
        public string Name { get; set; }
        public BirdType birdType { get; set; }
        // Association has - a relation
            // Composition
            // Aggregation
        // High level class should not depend on low level class
        public BirdBeak beak { get; set; }
        public int weight { get; set; }
        public BirdSize size { get; set; }

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
        Eagle,
        sparrow,
        parrot,
        penguin
    }
}
