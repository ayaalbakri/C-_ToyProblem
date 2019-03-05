using System;
using System.Linq;

namespace ToyProblem
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            int xxxn = n.ToString().Select(ele => int.Parse(ele.ToString())).Sum();
            if (xxxn > 9)
            {
                DigitalRoot(xxxn);
            }
            Console.WriteLine(xxxn);
            return xxxn;
        }
    }
}
