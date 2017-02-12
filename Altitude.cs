using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            long initialAltitude = long.Parse(inputArray[0]);
            for (int i = 1; i < inputArray.Length - 1; i+= 2)
            {
                string direction = inputArray[i];
                int number = int.Parse(inputArray[i + 1]);      
                switch (direction)
                {
                    case "up":
                        initialAltitude += number;
                        break;
                    case "down":
                        initialAltitude -= number;
                        break;
                }

                if (initialAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    break;
                }
            }

            if (initialAltitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", initialAltitude);

            }
        }
    }
}
