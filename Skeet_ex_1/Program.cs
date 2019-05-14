using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skeet_ex_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkWithCSharp1();
            WorkWithCScharp2();
            WorkWithCSharp3();
            WorkWithCSharp4();
        }

        private static void WorkWithCSharp1()
        {
            ArrayList productList = Product.GetSampleProducts();
            foreach (Product product in productList)
            {
                product.ToString();
            }
            //Looping
            foreach (Product product in productList)
            {
                if (product.Price > 10m)
                {
                    Console.WriteLine(product);
                }
            }
        }

        private static void WorkWithCScharp2()
        {
            List<Product2> productList2 = Product2.GetSampleProducts();
            foreach (Product2 product in productList2)
            {
                product.ToString();
            }

            //Sorting
            productList2.Sort(delegate (Product2 x, Product2 y)
            { return x.Name.CompareTo(y.Name); });

            foreach (Product2 product in productList2)
            {
                Console.WriteLine(product);
            }
            //or
            Predicate<Product2> test = delegate (Product2 p) { return p.Price > 10m; };
            List<Product2> matches = productList2.FindAll(test);

            Action<Product2> print = Console.WriteLine;
            matches.ForEach(print);

            //Looping
            Predicate<Product2> test2 = delegate (Product2 p) { return p.Price > 10m; };
            List<Product2> matches2 = productList2.FindAll(test2);

            Action<Product2> print2 = Console.WriteLine;
            matches2.ForEach(print2);
            //or
            productList2.FindAll(delegate (Product2 p) { return p.Price > 10; })
                    .ForEach(Console.WriteLine);
        }

        private static void WorkWithCSharp3()
        {
            List<Product3> productList3 = Product3.GetSampleProducts();
            foreach (Product3 product in productList3)
            {
                product.ToString();
            }

            // Sorting
            productList3.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Product3 product in productList3)
            {
                Console.WriteLine(product);
            }
            //or
            foreach (Product3 product in productList3.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }

            //Looping
            foreach (Product3 product in productList3.Where(p => p.Price > 10))
            {
                Console.WriteLine(product);
            }
        }

        private static void WorkWithCSharp4()
        {
            List<Product4> productList4 = Product4.GetSampleProducts();
            foreach (Product4 product in productList4)
            {
                product.ToString();
            }

            //Looping
        }
    }
}



