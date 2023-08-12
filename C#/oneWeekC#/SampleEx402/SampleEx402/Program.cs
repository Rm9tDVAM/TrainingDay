using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.Write(c.Name + " : ");
            c.Sing();
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
