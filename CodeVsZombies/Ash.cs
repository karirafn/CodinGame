using Common;
using System;

namespace CodeVsZombies
{
    public class Ash : IPositionable
    {
        public const int Speed = 1000;
        public const int Range = 2000;

        public Ash(string[] inputs)
        {
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            Position = new Point(x, y);
        }

        public Point Position { get; }

        public void Move(Point point) => Console.WriteLine($"{point.X} {point.Y}");
        public void Wait() => Move(Position);
    }
}
