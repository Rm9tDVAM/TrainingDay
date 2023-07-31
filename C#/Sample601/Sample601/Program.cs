using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            p1.name = "yamada tarou";
            p1.age = 19;
            p2.SetAgeAndName("satou hanako", 23);
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
