﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace E1_3
{
    class Primenum
    {
        static void Main(string[] args)
        {
            int n, m, i, flag = 0;
            Console.WriteLine("enter the num");
            n = Convert.ToInt32(Console.ReadLine());

            m = n / 2;
            for(i=2;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("not a prime");
                    flag = 1;
                    break;

                }
                if (flag == 0)
                    Console.WriteLine("prime");
            }

        }
    }
}
