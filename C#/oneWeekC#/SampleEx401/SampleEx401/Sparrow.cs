using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx401
{
    internal class Sparrow
    {
        private string name = "すずめ";
        public void Sing()
        {
            Console.WriteLine("ちゅんちゅん");
        }
        public string Name
        {
            get { return name; }
        }
    }
}
