using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String>a=new List<String>();
            a.Add("Taro");
            a.Add("Hanako");
            a.Add("Jiro");
            a.Add("Kaoru");
            a.Remove("Taro");
            a.RemoveAt(1);
            foreach(String s in a)
            {
                Console.WriteLine(s);
            }

        }
    }
}
