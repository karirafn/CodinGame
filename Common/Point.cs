using System;

namespace Common
{
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public double DistanceFrom(Point point) => Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
        public double DistanceFrom(IPositionable location) => DistanceFrom(location.Position);
    }
}
