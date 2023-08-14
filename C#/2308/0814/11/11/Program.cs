using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            var strList=new List<string>();
            strList.Add("A");
            strList.Add("B");
            strList.Add("C");
            strList.Add("D");
            strList.Add("E");
            strList.Add("F");
            strList.Add("G");
            strList.Add("H");
            strList.Add("I");
            strList.Add("J");
            strList.Add("K");
            strList.Add("L");
            strList.Add("M");
            strList.Add("N");
            strList.Add("O");
            strList.Add("P");
            strList.Add("Q");
            strList.Add("R");
            strList.Add("S");
            strList.Add("T");
            strList.Add("U");
            strList.Add("V");
            strList.Add("W");
            strList.Add("X");
            strList.Add("Y");
            strList.Add("Z");
            int three = 0;
            int two = 0;
            int one = 0;

            for (int i = 0; i < line; i++) {
                one++;
                if (one == 27)
                {
                    one = 1;
                    two++;
                }
                if (two == 27)
                {
                    two = 1;
                    three++;
                }
            }
            if (three != 0)
            {
                Console.Write(strList[three -1]);
            }
            if (two != 0)
            {
                Console.Write(strList[two -1]);

            }
            Console.Write(strList[one -1]);
            Console.WriteLine();
        }
    }
}