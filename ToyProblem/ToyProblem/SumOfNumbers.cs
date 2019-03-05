using System.Linq;

namespace ToyProblem
{
    public class SumOfNumbers
    {
        public static int Sum(int a, int b)
        {
            //Note: a almost larger than or equal b 
            if (a == b)
            {
                return a;
            }
            var result = Enumerable.Range(a, b + 1).Aggregate((c, d) => c + d);

            return result;
        }
    }
}
