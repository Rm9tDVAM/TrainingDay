using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1SampleEx202
{
    internal class Program
    {
        private static int snum=100;
        public int inum = 200;
        public static void foo()
        {
            Console.WriteLine("fooメソッド (staticメソッド)");
        }
        public void bar()
        {
            Console.WriteLine("barメソッド(インスタンスメソッド)");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("pのインスタンスフィールド:inum={0}", p.inum);
            Console.WriteLine("Programのクラスフィールド:snum={0}", snum);
            foo();
            p.bar();
        }
    }
}
