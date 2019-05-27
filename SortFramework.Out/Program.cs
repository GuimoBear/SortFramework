using SortFramework.Internal.Algorithms;
using SortFramework.Tests;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortFramework.Out
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteStressTestAndPrintResult(nameof(Bubblesort), Bubblesort.Sort);
            ExecuteStressTestAndPrintResult(nameof(Cocktailsort), Cocktailsort.Sort);
            ExecuteStressTestAndPrintResult(nameof(InsertionSort), InsertionSort.Sort);
            ExecuteStressTestAndPrintResult(nameof(MergeSort), MergeSort.Sort);
            ExecuteStressTestAndPrintResult(nameof(ShellSort), ShellSort.Sort);
            ExecuteStressTestAndPrintResult(nameof(CombSort), CombSort.Sort);
            ExecuteStressTestAndPrintResult(nameof(QuickSort), QuickSort.Sort);

            Console.ReadKey();
        }

        private static void ExecuteStressTestAndPrintResult(string algorithmDescription, Action<int[]> sort)
        {
            const int numberOfArrays = 50;
            const int startindex = -3000;
            const int elementCount = 6001;

            var watch = new Stopwatch();

            Console.WriteLine($"Iniciando {algorithmDescription} usando {numberOfArrays} arrays com {elementCount} elementos");
            var failsIndex = new List<int>();
            var index = 0;

            int totalObjectsGen0, totalObjectsGen1, totalObjectsGen2 = 0;

            using (var generator = new ArrayGenerator(numberOfArrays, startindex, elementCount))
            {                
                var beforeGen0 = GC.CollectionCount(0);
                var beforeGen1 = GC.CollectionCount(1);
                var beforeGen2 = GC.CollectionCount(2);

                watch.Start();

                while(generator.Next(out var generated))
                {
                    sort(generated);
                    if (!generator.SortWorked())
                        failsIndex.Add(index);
                    index++;
                }

                watch.Stop();

                var afterGen0 = GC.CollectionCount(0);
                var afterGen1 = GC.CollectionCount(1);
                var afterGen2 = GC.CollectionCount(2);

                totalObjectsGen0 = afterGen0 - beforeGen0;
                totalObjectsGen1 = afterGen1 - beforeGen1;
                totalObjectsGen2 = afterGen2 - beforeGen2;

                var areEquals = failsIndex.Count == 0;
                Console.Write($"{algorithmDescription} finalizado\n\ttempo total gasto: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{watch.ElapsedMilliseconds} ms\n\t");
                Console.ResetColor();
                Console.Write("Resultado foi correto: ");
                Console.ForegroundColor = areEquals ? ConsoleColor.Blue : ConsoleColor.Red;
                Console.WriteLine(areEquals);
                Console.ResetColor();
                Console.WriteLine("\tUso de memória: ");
                Console.Write("\t                Gen 0: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(totalObjectsGen0);
                Console.ResetColor();
                Console.Write("\t                Gen 1: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(totalObjectsGen1);
                Console.ResetColor();
                Console.Write("\t                Gen 2: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(totalObjectsGen2);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
