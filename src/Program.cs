using ordenamiento_anton.src;
using ordenamiento_anton.src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento_anton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 1_000, 5_000, 10_000 };
            var rand = new Random();

            var algos = new Dictionary<string, Action<List<int>>>
            {
                ["Bubble"] = Algorithms.BubbleSort,
                ["Shaker"] = Algorithms.Shaker,
                ["Insertion"] = Algorithms.InsertionSort,
                ["Selection"] = Algorithms.SelectionSort,
                ["Shell"] = Algorithms.ShellSort,
                ["Quick"] = Algorithms.QuickSort,
                ["Heap"] = Algorithms.HeapSort,
            };

            foreach (var size in sizes)
            {
                var baseData = Enumerable.Range(0, size)
                                         .Select(_ => rand.Next())
                                         .ToList();

                Console.WriteLine($"\n\nTamaño de entrada: {size:N0}");
                Console.WriteLine(new string('-', 35));
                Console.WriteLine($"{"Algoritmo",-12} | {"Tiempo (ms)",12}");
                Console.WriteLine(new string('-', 35));

                foreach (var kvp in algos)
                {
                    var copy = new List<int>(baseData);
                    var elapsed = Timer.Measure(() => kvp.Value(copy));
                    Console.WriteLine($"{kvp.Key,-12} | {elapsed.TotalMilliseconds,12:N2}");
                }
            }

            Console.WriteLine("\nFin de las pruebas. Presiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}
