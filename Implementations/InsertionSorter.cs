using Algorithms.Interfaces;

namespace Algorithms.Implementations
{
    public class InsertionSorter : ISorter
    {
        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}