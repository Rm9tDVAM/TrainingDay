using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace c061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ≦ A, B ≦ 999
            string[] line = Console.ReadLine().Split(' ');
            string A = line[0];
            string B = line[1];
            //string A = "123";
            //string B = "8";
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            string tmp;

            ReverseList(A,aList);
            ReverseList(B,bList);

            for ( int i = 0; i < 3; i++)
            {
                //Console.WriteLine("{0},{1}", aList[i], bList[i]);
                tmp = (aList[i] + bList[i]).ToString();
                Console.Write(tmp.Substring(0,1));
            }
        }
        static void ReverseList(string A,List<int> list)
        {
            int offset = 3 - A.Length;

            for (int i = 0; i < offset; i++)
            {
                list.Add(0);
            }

            for (int i = 0; i < A.Length; i++)
            {
                list.Add(int.Parse(A.Substring(i,1)));
            }
        }
    }
}
