using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeVsZombies.Strategies
{
    public class MoveToClosestSavableHuman : IStrategy
    {
        private readonly Game _game;

        public MoveToClosestSavableHuman(Game game)
        {
            _game = game;
        }

        public void Act()
        {
            Human target = _game.Humans
                .Where(human => IsSavable(human))
                .OrderBy(human => human.Position.DistanceFrom(_game.Ash))
                .FirstOrDefault()
                ?? _game.Humans.FirstOrDefault();

            if (target is null)
                _game.Ash.Wait();
            else
                _game.Ash.Move(target.Position);
        }

        private bool IsSavable(Human human)
            => NeedsSaving(human) && TurnsUntilWithinRange(_game.Ash, human, Ash.Range, Ash.Speed) < TurnsUntilWithinRange(human, GetClosestTargetingZombie(human), Zombie.Speed, Zombie.Speed);

        private bool NeedsSaving(Human human)
            => _game.Zombies.Any(zombie => zombie.IsHeadedTo(human));

        private Zombie GetClosestTargetingZombie(Human human)
            => _game.Zombies
                .Where(zombie => zombie.IsHeadedTo(human))
                .OrderBy(zombie => zombie.Position.DistanceFrom(human))
                .FirstOrDefault();

        private int TurnsUntilWithinRange(IPositionable a, IPositionable b, int range, int speed)
            => (int)Math.Ceiling((a.Position.DistanceFrom(b) - range) / speed);
    }
}
