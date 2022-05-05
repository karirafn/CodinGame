namespace Common
{
    public struct Vector
    {
        public Vector(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public Point P1 { get; }
        public Point P2 { get; }

        public double Length => P1.DistanceFrom(P2);
        public bool Contains(Point p3) => Length == P1.DistanceFrom(p3) + P2.DistanceFrom(p3);
    }
}
