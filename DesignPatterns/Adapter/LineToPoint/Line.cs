using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.LineToPoint
{
    public class Line
    {
        public Point Start;
        public Point End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override bool Equals(object? obj)
        {
            return obj is Line line &&
                   EqualityComparer<Point>.Default.Equals(Start, line.Start) &&
                   EqualityComparer<Point>.Default.Equals(End, line.End);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }
    }
}
