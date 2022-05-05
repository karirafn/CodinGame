using System.Collections.Generic;

namespace CodeVsZombies
{
    class Game
    {
        public const int Width = 16000;
        public const int Height = 9000;

        private Human[] _humans;
        private Zombie[] _zombies;

        public int Score { get; private set; } = 0;
        public Ash Ash { get; private set; }
        public int HumanCount { get; private set; }
        public int ZombieCount { get; private set; }
        public IEnumerable<Human> Humans => _humans;
        public IEnumerable<Zombie> Zombies => _zombies;

        public void SetHumanCount(int count)
        {
            HumanCount = count;
            _humans = new Human[count];
        }

        public void SetZombieCount(int count)
        {
            ZombieCount = count;
            _zombies = new Zombie[count];
        }

        public void SetAsh(string[] inputs) => Ash = new Ash(inputs);
        public void AddHuman(int index, string[] inputs) => _humans[index] = new Human(inputs);
        public void AddZombie(int index, string[] inputs) => _zombies[index] = new Zombie(inputs);
    }
}
