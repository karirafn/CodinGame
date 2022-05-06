using CodeVsZombies.Strategies;

namespace CodeVsZombies
{
    public class Strategy
    {
        public static void MoveToClosestZombie(Game game) => new MoveToClosestZombie(game).Act();
        public static void MoveToClosestHuman(Game game) => new MoveToClosestHuman(game).Act();
        public static void MoveToClosestSavableHuman(Game game) => new MoveToClosestSavableHuman(game).Act();
    }
}
