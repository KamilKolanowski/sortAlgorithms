using Algorithms.Interfaces;

namespace Algorithms.Implementations
{
    public class SelectionSorter : ISorter
    {
        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var min = i;

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                var temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }
    }
}