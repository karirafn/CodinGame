using Common;
using System.Linq;

namespace CodeVsZombies.Strategies
{
    public class MoveToClosestHuman : IStrategy
    {
        private readonly Game _game;

        public MoveToClosestHuman(Game game)
        {
            _game = game;
        }

        public void Act()
        {
            IOrderedEnumerable<Human> humans = _game.Humans.OrderBy(human => human.Position.DistanceFrom(_game.Ash));

            if (humans.Any())
                _game.Ash.Move(humans.First().Position);
            else
                _game.Ash.Wait();
        }
    }
}
