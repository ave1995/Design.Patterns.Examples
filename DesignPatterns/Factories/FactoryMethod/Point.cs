using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factories.FactoryMethod
{
    internal enum CoordinateSystem
    {
        Cartesian,
        Polar
    }
    internal class Point
    {
        private double x, y;

        protected Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //Wrong way
        public Point(double a, double b, // names do not communicate intent
            CoordinateSystem cs = CoordinateSystem.Cartesian)
        {
            switch (cs)
            {
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    x = a;
                    y = b;
                    break;
            }

            // steps to add a new system
            // 1. augment CoordinateSystem
            // 2. change ctor
        }

        // factory property
        public static Point Origin => new Point(0, 0); //always create new

        // singleton field
        public static Point Origin2 = new Point(0, 0); //only one

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            //...
            return null;
        }
        // make it lazy
        public static class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x} {nameof(y)}: {y}";
        }
    }
    internal class PointFactory
    {
        public static Point NewCartesianPoint(float x, float y)
        {
            return new Point(x, y); // needs to be public
        }
    }
}
