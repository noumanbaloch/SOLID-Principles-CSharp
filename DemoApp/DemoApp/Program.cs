﻿using CalculatorLibrary;
using SOLID;
using SOLID.OpenClosedPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculate();
            Product.Stock();
            Console.ReadKey();
        }

    }
}
