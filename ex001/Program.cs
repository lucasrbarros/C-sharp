﻿using System;
using System.Globalization;

namespace ex001
{
    class program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8;

            double a = 1.0, b = -3.0, c = -4.0;


            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
=======
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            double preco3 = 890;
 master

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

    }
}