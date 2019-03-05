using System;
using System.Linq;

namespace ToyProblem
{
    public class DescendingOrder
    {
        public static int DescendingOrderNumber(int num)
        {
            // Bust a move right here
            var result = int.Parse(string.Join("", num.ToString().OrderByDescending(ele => ele).ToList()));
            Console.WriteLine(result);
            return result;
        }
    }
}
