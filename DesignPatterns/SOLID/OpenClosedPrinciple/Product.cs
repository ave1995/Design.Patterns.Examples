using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.OpenClosedPrinciple
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Color = color;
            Size = size;
        }
    }

    //public class ProductFilter
    //{
    //    // let's suppose we don't want ad-hoc queries on products
    //    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    //    {
    //        foreach (var p in products)
    //            if (p.Color == color)
    //                yield return p;
    //    }

    //    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    //    {
    //        foreach (var p in products)
    //            if (p.Size == size)
    //                yield return p;
    //    }

    //    public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    //    {
    //        foreach (var p in products)
    //            if (p.Size == size && p.Color == color)
    //                yield return p;
    //    } // state space explosion
    //      // 3 criteria = 7 methods

    //    // OCP = open for extension but closed for modification
    //}
}
