using System;
using System.Linq;

namespace ToyProblem
{
    public class DontGiveMeFive
    {
        public static int DontGiveMeFiveMethod(int start, int end)
        {
            var count = 0;
            for (int i = start; i <= end; i++)
            {
                if (!i.ToString().Contains('5'))
                {
                    count++;
                }

            }
            var x = Enumerable.Range(start, end - start + 1).Count(ele => !ele.ToString().Contains('5'));
            Console.WriteLine(x);

            Console.WriteLine(count);
            return count;
        }
    }
}
