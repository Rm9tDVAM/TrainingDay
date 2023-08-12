using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx604
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> t= new HashSet<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(1);
            foreach(int i in t)
            {
                Console.WriteLine("{0}",i);
            }
        }
    }
}
