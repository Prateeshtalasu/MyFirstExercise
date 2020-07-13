using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_4
{
    class tempvar
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("entertwonum");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine("the number:" + a);
            Console.WriteLine("the number:" + b);
        }
    }
}
