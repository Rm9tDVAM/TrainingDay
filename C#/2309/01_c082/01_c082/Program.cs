﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] line = Console.ReadLine().Split(' ');
            string[] line = { "4","2" };
            List<string>list=new List<string>();
            List<int>engList=new List<int>();
            List<int>jpnList=new List<int>();
            List<int>matList=new List<int>();
            int ans = 0;
            string[] temp;

            //for(int i = 0; i < int.Parse(line[0]); i++)
            //{
            //list.Add(line[i]);
            //}
            list.Add("80 60 40");
            list.Add("50 50 40");
            list.Add("80 50 40");
            list.Add("40 80 80");
            foreach (string i in list)
            {
                temp = i.Split(' ');
                engList.Add(int.Parse(temp[0]));
                jpnList.Add(int.Parse(temp[1]));
                matList.Add(int.Parse(temp[2]));
            }
            for(int i = 0; i < list.Count; i++)
            {
                temp = list[i].Split(' ');
                getNum(engList, int.Parse(line[1])-1);

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
