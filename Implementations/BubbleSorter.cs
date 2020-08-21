using Algorithms.Interfaces;

namespace Algorithms.Implementations
{
    public class BubbleSorter : ISorter
    {
        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}