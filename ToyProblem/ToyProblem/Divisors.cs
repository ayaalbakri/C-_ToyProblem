using System.Collections.Generic;

namespace ToyProblem
{
    public class Divisors
    {
        private static List<int> termsList = new List<int>();

        public static int[] Divisor(int n)
        {
            #region 
            //Create a function named divisors / Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
            #endregion

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    termsList.Add(i);
                }
            }
           
            return termsList.ToArray();
        }
    }
}
