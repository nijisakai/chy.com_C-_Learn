﻿//命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//项目名称
namespace mydemo
{
    //类名称，苦力
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            Console.ReadKey();
            //Console.WriteLine("aloha! Hello, World");
            //Console.ReadKey();
        }
        public static int GetMy(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        public class Person
        {
            public int Age
            {
                get;
                set;
            }
            public char Gender
            {
                get;
                set;
            }
        }
    }
}