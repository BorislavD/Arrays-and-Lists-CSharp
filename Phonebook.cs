using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phonenumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string input = Console.ReadLine();
            while (!input.Equals("done"))
            {
                string name = input;
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Contains(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonenumbers[i]);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
