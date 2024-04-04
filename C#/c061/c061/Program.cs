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
            string[] line = Console.ReadLine().Split(' ');
            string A = line[0];
            string B = line[1];
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            List<int> ansList = new List<int>();
            string tmp;
            int maxLength = Math.Max(A.Length, B.Length);

            ReverseList(A,aList,maxLength);
            ReverseList(B,bList,maxLength);

            for ( int i = 0; i < maxLength; i++)
            {
                tmp = (aList[i] + bList[i]).ToString();
                ansList.Add((int.Parse(tmp.Substring(tmp.Length -1, 1))));
            }

            foreach ( int i in ansList)
            {
                Console.Write(i);
            }

        }
        static void ReverseList(string str,List<int> list,int maxLength)
        {
            int offset = maxLength - str.Length;

            for (int i = 0; i < offset; i++)
            {
                list.Add(0);
            }

            for (int i = 0; i < str.Length; i++)
            {
                list.Add(int.Parse(str.Substring(i,1)));
            }
        }
    }
}
