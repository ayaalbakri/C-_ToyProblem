using System;

namespace ToyProblem
{
    public class SortArray
    {
        public static int[] SortArrayOddAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] % 2 != 0 && array[j] % 2 != 0 && array[j] < array[i])
                    {
                        var swap = array[j];
                        array[j] = array[i];
                        array[i] = swap;
                    }
                }
            }

            //array.Select(ele=>)
            Console.WriteLine(array);
            return array;
        }
    }
}
