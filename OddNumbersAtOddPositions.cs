﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.WriteLine("Index {0} -> {1}", i, numbers[i]);
                    }
                }
            }
        }
    }
}
