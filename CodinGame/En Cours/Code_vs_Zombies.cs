using System;
using System.Collections.Generic;
using System.Linq;

namespace CodinGame.En_Cours
{
    /**
    * Save humans, destroy zombies!
     **/
    internal class Code_vs_Zombies
    {
        const int spartanSpeed = 1000;
        const int zombieSpeed = 400;
        const int killingDistance = 2000;
        const double speedDifferenceMultiplier = (double)spartanSpeed / zombieSpeed;

        static double GetDistance(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
        }

        protected void Output(string[] args)
        {


            // game loop
            while (true)
            {
                List<Human> humans = new List<Human>();
                List<Zombie> zombies = new List<Zombie>();
                string[] spartanCoordinates = Console.ReadLine().Split(' ');
                MasterChief masterChief = new MasterChief
                {
                    X = int.Parse(spartanCoordinates[0]),
                    Y = int.Parse(spartanCoordinates[1]),
                    NextX = 0,
                    NextY = 0
                };

                Console.Error.WriteLine($"Master Chief 😎: {masterChief}");
                Console.Error.WriteLine("************************** New Turn Starts ⚔️ ***************************");

                int humanCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < humanCount; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    Human human = new Human
                    {
                        Id = int.Parse(inputs[0]),
                        X = int.Parse(inputs[1]),
                        Y = int.Parse(inputs[2]),
                        Distance = 0,
                        Alive = true
                    };
                    human.Distance = GetDistance(masterChief, human);
                    humans.Add(human);
                }
                humans = humans.OrderBy(h => h.Distance).ToList(); // necessary?

                Human ryan = null; // ryan or nemo?

                int zombieCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < zombieCount; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    // if we already have a ryan/nemo, skip the rest of the zombies
                    if (ryan != null) continue;
                    Zombie zombie = new Zombie
                    {
                        Id = int.Parse(inputs[0]),
                        X = int.Parse(inputs[1]),
                        Y = int.Parse(inputs[2]),
                        NextX = int.Parse(inputs[3]),
                        NextY = int.Parse(inputs[4])
                    };
                    Console.Error.WriteLine($"Zombie #{zombie.Id} vs humans: {zombie}");
                    // can Master Chief reach any of the humans before this zombie? find nemo!
                    List<Human> ryans = humans.Where(h =>
                    {
                        Console.Error.WriteLine("---");
                        Console.Error.WriteLine($"Human: {h}");
                        double hDistance = GetDistance(zombie, h);
                        Console.Error.WriteLine($"Distance (zombie to human): {hDistance}");
                        bool isSpartanCloser = h.Distance - killingDistance < hDistance;
                        Console.Error.WriteLine($"Is Master Chief Closer?: {isSpartanCloser}");
                        return isSpartanCloser;
                    }).ToList();
                    Console.Error.WriteLine($"Ryans: {string.Join(", ", ryans)}");
                    // any ryans so far?
                    if (ryans.Count > 0)
                    {
                        // found a ryan!
                        ryans = ryans.OrderBy(h => h.Distance).ToList();
                        Console.Error.WriteLine($"Ryans: {string.Join(", ", ryans)}");
                        ryan = ryans[0];
                        Console.Error.WriteLine("- Cortana: Master Chief, we found Nemo! 🚨 RESCUE RYAN! 🚨");
                        // (this metaphor is out of control... 😅)
                    }

                    zombies.Add(zombie); // do I need to store zombies?
                    Console.Error.WriteLine("-----------------------------------------");
                }

                Human next = ryan ?? humans[0];
                masterChief.NextX = next.X;
                masterChief.NextY = next.Y;

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine('Debug messages...');

                Console.WriteLine($"{masterChief.NextX} {masterChief.NextY}"); // Your destination coordinates

            }
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Human : Point
    {
        public int Id { get; set; }
        public double Distance { get; set; }
        public bool Alive { get; set; }

        public override string ToString()
        {
            return $"Human(Id={Id}, X={X}, Y={Y}, Distance={Distance}, Alive={Alive})";
        }
    }

    public class Zombie : Point
    {
        public int Id { get; set; }
        public int NextX { get; set; }
        public int NextY { get; set; }

        public override string ToString()
        {
            return $"Zombie(Id={Id}, X={X}, Y={Y}, NextX={NextX}, NextY={NextY})";
        }
    }

    public class MasterChief : Point
    {
        public int NextX { get; set; }
        public int NextY { get; set; }

        public override string ToString()
        {
            return $"MasterChief(X={X}, Y={Y}, NextX={NextX}, NextY={NextY})";
        }
    }
}

