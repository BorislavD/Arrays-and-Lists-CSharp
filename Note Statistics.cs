using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<string> notes = "C C# D D# E F F# G G# A A# B".Split().ToList();
            List<double> frequencies = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88"
                .Split().Select(double.Parse).ToList();

            List<string> resultNotes = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                int frequencyIndex = frequencies.IndexOf(input[i]);
                string note = notes[frequencyIndex];
                resultNotes.Add(note);
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", resultNotes));

            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            for (int i = 0; i < resultNotes.Count; i++)
            {
                if (resultNotes[i].Contains("#"))
                {
                    sharps.Add(resultNotes[i]);
                }
                else
                {
                    naturals.Add(resultNotes[i]);
                }
            }

            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));

            double naturalsSum = 0.0;
            double sharpsSum = 0.0;

            for (int i = 0; i < naturals.Count; i++)
            {
                int frequencyIndex = notes.IndexOf(naturals[i]);
                double frequency = frequencies[frequencyIndex];
                naturalsSum += frequency;
            }

            for (int i = 0; i < sharps.Count; i++)
            {
                int frequencyIndex = notes.IndexOf(sharps[i]);
                double frequency = frequencies[frequencyIndex];
                sharpsSum += frequency;
            }

            Console.WriteLine("Naturals sum: {0}", naturalsSum);
            Console.WriteLine("Sharps sum: {0}", sharpsSum);

            for (int i = 0; i < input.Count; i++)
            {
                Console.Beep((int)input[i], 3000);
            }
        }
    }
}
