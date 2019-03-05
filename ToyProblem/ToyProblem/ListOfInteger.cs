using System.Collections.Generic;
using System.Linq;

namespace ToyProblem
{
    public class ListOfInteger
    {
        public static List<int> integers = new List<int>();
        public static List<int> ListOfIntegers(List<object> list)
        {
            integers = list.Where(x => x is int).Cast<int>().ToList();

            return integers;
            //return list.OfType<int>().ToList();
            ////Console.WriteLine(xxxxxx);
            //for (int i = 0; i < list.Count(); i++)
            //{
            //    if (list[i] is int)
            //    {
            //        integers.Add((int)list[i]);
            //    }
            //}
            //return integers;
        }
    }
}
