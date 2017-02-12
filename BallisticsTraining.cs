using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            long[] targetCoordinates = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string[] commands = Console.ReadLine().Split();

            long targetX = targetCoordinates[0];
            long targetY = targetCoordinates[1];

            long X = 0;
            long Y = 0;

            for (int i = 0; i < commands.Length - 1; i+= 2)
            {
                string direction = commands[i];
                long number = long.Parse(commands[i + 1]);

                switch (direction)
                {
                    case "up":
                        Y += number;
                        break;
                    case "down":
                        Y -= number;
                        break;
                    case "left":
                        X -= number;
                        break;
                    case "right":
                        X += number;
                        break;
                }
            }

            Console.WriteLine("firing at [{0}, {1}]", X, Y);

            if ((targetX == X) && (targetY == Y))
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
