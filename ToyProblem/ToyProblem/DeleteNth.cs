using System;
using System.Collections.Generic;
using System.Linq;

namespace ToyProblem
{
    public class DeleteNth
    {
        private static List<int> result = new List<int>();
        //Delete occurrences of an element if it occurs more than n times
        public static int[] DeleteNthFromArray(int[] arr, int x)
        {
            //way //var count = arr.Count(i => i == 1);
            for (int i = 0; i < arr.Count(); i++)
            {
                //int? countOfElement;
                if (result.Count(ele => ele == arr[i]) < x)
                {
                    result.Add(arr[i]);
                }
            }
            Console.WriteLine(result);
            return result.ToArray();
        }
    }
}
