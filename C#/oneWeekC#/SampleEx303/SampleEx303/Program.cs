using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p=new Parent();
            Parent c = new Child();
            p.Foo();
            c.Foo();
        }
    }
}
