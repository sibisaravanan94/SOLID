using SOLID.Version2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Bird> birds = new List<Bird>();
            // Subtyping
            // ex for subtyping - Bird bird = new Eagle()
            void flyAllBirds(List<Bird> birds)
            {
                foreach(Bird bird in birds)
                {
                    bird.fly();
                }
            }
        }
    }
}
