using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate md = () => {  Console.WriteLine("lambad表达式");  };
            md();
            Console.ReadKey();
        }
    }

    public delegate void MyDelegate();
}
