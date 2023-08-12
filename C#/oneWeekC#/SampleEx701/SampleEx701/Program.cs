using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            p1.Name = "yamada tarou";
            p1.Age = 19;
            p2.SetAgeAndName("satou hanako", 23);
            p1.ShowAgeAndName();
            Console.WriteLine("名前：{0} 年齢：{1}", p2.Name, p2.Age);
        }
    }
}
