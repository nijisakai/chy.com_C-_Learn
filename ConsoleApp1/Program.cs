using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            Console.WriteLine("第一个数字是" + n1 + "，第二个数字是" + n2 + "，第三个数字是" + n3);
            Console.WriteLine("第一个数字是{2}，第二个数字是{3}，第三个数字是{2}", n3, n3, n1 , n3);
            //占位符要一一对应。
            Console.ReadKey();

        }
    }
}
