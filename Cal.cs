﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalExample
{
    public class Cal
    {
        public void Add(double n1, double n2)
        {
            Console.WriteLine("Result after addition: \t" + (n1 + n2));
        }
        public void Sub(double n1, double n2)
        {
            Console.WriteLine("Result after Subtraction: \t" + (n1 - n2));
        }
        public void Mul(double n1, double n2)
        {
            Console.WriteLine("Result after Mulitplication: \t" + (n1 * n2));
        }
        public void Div(double n1, double n2)
        {
            Console.WriteLine("Result after Division: \t" + (n1 / n2));
        }
    }
}

