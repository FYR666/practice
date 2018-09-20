using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice22
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("请输入x的值：");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入y的值：");
            y = float.Parse(Console.ReadLine());
            float max = x > y ? x : y;
            Console.WriteLine("max="+max);
            Console.ReadKey();
        }
    }
}
