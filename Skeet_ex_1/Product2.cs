using System.Collections.Generic;

namespace Skeet_ex_1
{
    /// <summary>
    /// Class written in C# 2, strong typing and private setters.
    /// </summary>
    public class Product2
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price {
            get { return price; }
            private set { price = value; }
        }
        public Product2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public static List<Product2> GetSampleProducts()
        {
            List<Product2> list = new List<Product2>();
            list.Add(new Product2("West Side Story", 9.99m));
            list.Add(new Product2("Assassins", 14.99m));
            list.Add(new Product2("Frogs", 13.99m));
            list.Add(new Product2("Sweeney Todd", 10.99m));
            return list;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
