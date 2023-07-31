using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            p.SetAgeAndName("山田 太郎", 26);
            p.Age = 32;
            Console.WriteLine("名前:{0} 年齢:{1}", p.Name, p.Age);
        }
    }
}
