using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx401
{
    internal class Crow
    {
        private String name = "カラス";
        public void Sing()
        {
            Console.WriteLine("カーカー"); 
        }
        public String Name
        {
            get { return name; }
        }
    }
}
