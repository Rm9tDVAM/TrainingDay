using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = int.Parse(Console.ReadLine());
            int count = 8;
            List<string> list = new List<string>();
            for(int i = 0; i < count; i++)
            {
                //list.Add(Console.ReadLine());
            }
            int ans = 0;
            string[] tempi;
            string[] tempj;
            list.Add("A R");
            list.Add("A L");
            list.Add("B R");
            list.Add("A L");
            list.Add("A R");
            list.Add("B L");
            list.Add("A L");
            list.Add("C L");
            for(int i = 0; i < list.Count; i++)
            {
                tempi = list[i].Split(' ');
                for (int j = 0; j < list.Count; j++)
                {
                    tempj = list[j].Split(' ');
                    if (tempi[0] == tempj[0] && tempi[1] != tempj[1]) 
                    {


                    }
                }
            }
        }
    }
}
