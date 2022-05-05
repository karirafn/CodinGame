using Common;

namespace CodeVsZombies
{
    public class Human : IPositionable
    {
        public Human(string[] inputs)
        {
            Id = int.Parse(inputs[0]);
            int x = int.Parse(inputs[1]);
            int y = int.Parse(inputs[2]);
            Position = new Point(x, y);
        }

        public int Id { get; }
        public Point Position { get; set; }
    }
}
