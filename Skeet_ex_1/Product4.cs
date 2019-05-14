using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeet_ex_1
{
    /// <summary>
    /// Class written in C# 3, named arguments.
    /// </summary>
    class Product4
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public Product4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product4> GetSampleProducts()
        {
            return new List<Product4>
            {
                new Product4( name: "West Side Story", price: 9.99m),
                new Product4( name: "Assassins", price: 14.99m),
                new Product4( name: "Frogs", price: 13.99m),
                new Product4( name: "Sweeney Todd", price: 10.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
