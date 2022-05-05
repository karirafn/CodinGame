using CodeVsZombies.Strategies;
using Common;
using System;

namespace CodeVsZombies
{
    public class Player
    {
        static void Main()
        {
            Game game = new Game();

            while (true)
            {
                game.SetAsh(Console.ReadLine().Split(' '));

                game.SetHumanCount(int.Parse(Console.ReadLine()));
                for (int i = 0; i < game.HumanCount; i++)
                {
                    game.AddHuman(i, Console.ReadLine().Split(' '));
                }

                game.SetZombieCount(int.Parse(Console.ReadLine()));
                for (int i = 0; i < game.ZombieCount; i++)
                {
                    game.AddZombie(i, Console.ReadLine().Split(' '));
                }

                IStrategy strategy = new MoveToClosestZombie(game);

                strategy.Act();
            }
        }
    }
}