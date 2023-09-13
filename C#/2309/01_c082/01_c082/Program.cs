using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            List<string>list=new List<string>();
            List<int>engList=new List<int>();
            List<int>jpnList=new List<int>();
            List<int>matList=new List<int>();
            string[] temp;
            int[] multiPoint = new int[3];
            int ans=0;

            for(int i = 0; i < int.Parse(line[0]); i++)
            {
                list.Add(Console.ReadLine());
            }

            foreach (string i in list)
            {
                temp = i.Split(' ');
                engList.Add(int.Parse(temp[0]));
                jpnList.Add(int.Parse(temp[1]));
                matList.Add(int.Parse(temp[2]));
            }

            multiPoint[0] = getNum(engList, int.Parse(line[1])-1);
            multiPoint[1] = getNum(jpnList, int.Parse(line[1])-1);
            multiPoint[2] = getNum(matList, int.Parse(line[1])-1);
            for(int i = 0; i < list.Count; i++)
            {
                temp = list[i].Split(' ');
                for(int j = 0; j < 3; j++)
                {
                    if (int.Parse(temp[j]) <= multiPoint[j])
                    {
                        ans++;
                    }
                }
                Console.WriteLine(ans);
                ans = 0;
            }
        }
        static int getNum(List<int> list,int index) 
        {
            List<int>tempList=new List<int>();
            foreach(int i in list)
            {
                tempList.Add(i);
            }
            tempList.Sort();
            return tempList[index];
        }
    }
}
