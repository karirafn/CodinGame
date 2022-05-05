using System;
using System.Linq;

namespace CodeVsZombies
{
    public class Player
    {
        static void Main()
        {
            Game game = new Game();

            // game loop
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

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                var zombies = game.Zombies.OrderBy(z => z.Position.DistanceFrom(game.Ash));

                if (zombies.Any())
                    game.Ash.Move(zombies.First().Position);
                else
                    game.Ash.Wait();
            }
        }
    }
}