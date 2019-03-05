using System;
using System.Linq;

namespace ToyProblem
{
    public class OddOccurance
    {
        public static int FirstOddOccurance(int[] seq)
        {
            // var xxx = seq.Select(ele => seq.Count(num => num == ele) % 2 != 0 ? ele);
            int oddNum = seq.First(ele => seq.Count(num => num == ele) % 2 != 0);
            Console.WriteLine(oddNum);

            //Console.WriteLine(index);
            return -1;
        }
    }
}
