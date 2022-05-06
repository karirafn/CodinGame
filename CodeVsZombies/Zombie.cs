using Common;

namespace CodeVsZombies
{
    public class Zombie : IPositionable
    {
        public const int Speed = 400;

        public Zombie(string[] inputs)
        {
            Id = int.Parse(inputs[0]);
            int x = int.Parse(inputs[1]);
            int y = int.Parse(inputs[2]);
            int dx = int.Parse(inputs[3]);
            int dy = int.Parse(inputs[4]);
            Position = new Point(x, y);
            Destination = new Point(dx, dy);
        }

        public int Id { get; }
        public Point Position { get; }
        public Point Destination { get; set; }

        public bool IsHeadedTo(Human human)
            => new Vector(human.Position, Position).Contains(Destination);
    }
}
