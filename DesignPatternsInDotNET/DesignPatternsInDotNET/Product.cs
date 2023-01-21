﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Product : IComposite
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double CalculatePrice()
        {
            Console.WriteLine($"Price of product {Name}: {Price} HUF");
            return Price;
        }
    }
}
