using System;
using System.IO;
using System.Linq;
using Algorithms.Implementations;
using Algorithms.Interfaces;

namespace Algorithms
{
    public class Algorithms
    {
        private readonly string filePath;

        public Algorithms(string filePath)
        {
            this.filePath = filePath;
        }

        public void Run(string fileName, int minRange, int maxRange, int arraySize, int intervals, bool sorted)
        {
            var bubbleSorter = new BubbleSorter();
            var insertionSorter = new InsertionSorter();
            var selectionSorter = new SelectionSorter();

            for (var interval = 1; interval <= intervals; interval++)
            {
                var array = GenerateRandomArray(minRange, maxRange, arraySize * interval);

                if (sorted) array = array.OrderBy(x => x).ToArray();

                var result = "";

                result += PerformTests(array, bubbleSorter) + ",";
                result += PerformTests(array, insertionSorter) + ",";
                result += PerformTests(array, selectionSorter);

                SaveResult(result, fileName);
            }
        }

        private string PerformTests(int[] array, ISorter sorter)
        {
            var tempArray = new int[array.Length];
            Array.Copy(array, tempArray, array.Length);
            return GetSortingTime(tempArray, sorter);
        }

        private string GetSortingTime(int[] array, ISorter sorter)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            sorter.Sort(array);
            watch.Stop();

            var elapsedTime = watch.ElapsedMilliseconds;

            return Convert.ToString(elapsedTime);
        }

        private void SaveResult(string result, string fileName)
        {
            using (var writer = File.AppendText(filePath + fileName + ".txt"))
            {
                writer.WriteLine(result);
            }
        }
        
        private static int[] GenerateRandomArray(int minRange, int maxRange, int arraySize)
        {
            var rnd = new Random();
            var array = new int[arraySize];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minRange, maxRange);
            }

            return array;
        }
    }
}