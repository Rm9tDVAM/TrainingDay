using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx702
{
    internal class Program
    {
        delegate void Action(int a);
        static void Func1(int a)
        {
            Console.WriteLine("a={0}",a);
        }
        static void Func2(int a)
        {
            Console.WriteLine("a*2={0}", a * 2);
        }
        static void Func3(int a)
        {
            Console.WriteLine("a*3={0}", a * 3);
        }
        static void Main(string[] args)
        {
            Action a = new Action(Func1);
            a += new Action(Func2);
            a += new Action(Func3);
            a(3);
        }
    }
}
