using DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.getSingleton();
            Singleton s1 = Singleton.getSingleton();
            if (s == s1)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("not Same");
            }
        }
    }
}
