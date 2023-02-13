using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            var elves = new Dictionary<int, int>();
            var lines = System.IO.File.ReadLines(@"C:\Users\AG Games Engineering\source\repos\AdventOfCode_1\input_day_1.txt");
            int counter = 0;
            elves.Add(counter, 0);
            foreach (var line in lines)
            {
                if (line.Length == 0)
                {
                    counter++;
                    elves.Add(counter, 0);
                }
                else
                {
                    var value = int.Parse(line);
                    elves[counter] += value;
                    //Console.WriteLine(elves[counter]);
                }
            }
            //KeyValuePair<int, int> currentChampion = new KeyValuePair<int, int>(0, elves[0]);
            //foreach (var elf in elves)
            //{
            //    if (elf.Value > currentChampion.Value)
            //    {
            //        currentChampion = elf;
            //    }
            //}
            //Console.WriteLine("And the winner is: " + currentChampion.Value);

            // Zweite Aufgabe:
            var sortedElves = elves.OrderByDescending(key => key.Value);
            int numberOfTopElves = 3;
            int sumOfSnacks = 0;
            foreach (var elf in sortedElves)
            {
                if (numberOfTopElves > 0)
                {
                    sumOfSnacks += elf.Value;
                    Console.WriteLine("Add " + elf.Value);
                    numberOfTopElves--;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("FIRST And the winner is: " + sumOfSnacks);

            // Zweite Variante:
            numberOfTopElves = 3;
            sumOfSnacks = 0;
            for (int i = 0; i < numberOfTopElves; i++)
            {
                Console.WriteLine("Add " + sortedElves.ElementAt(i).Value);
                sumOfSnacks += sortedElves.ElementAt(i).Value;
            }
            Console.WriteLine("SECOND And the winner is: " + sumOfSnacks);
        }
    }
}
