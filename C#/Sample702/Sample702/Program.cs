using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Access a=new Access();
            a.Data2 = 2;
            a.ShowDates();
            Console.WriteLine("a.data1 = {0}", a.Data1);
        }
    }
}
