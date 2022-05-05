using Common;
using System.Linq;

namespace CodeVsZombies.Strategies
{
    public class MoveToClosestZombie : IStrategy
    {
        private readonly Game _game;

        public MoveToClosestZombie(Game game)
        {
            _game = game;
        }

        public void Act()
        {
            IOrderedEnumerable<Zombie> zombies = _game.Zombies.OrderBy(z => z.Position.DistanceFrom(_game.Ash));

            if (zombies.Any())
                _game.Ash.Move(zombies.First().Position);
            else
                _game.Ash.Wait();
        }
    }
}
