using System;
using System.Linq;

namespace ToyProblem
{
    public class Persist
    {
        //private static List<int> listOfInts;
        //private static int count = 1;
        //private static IEnumerable<int> xxx;
        #region
        //        Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

        //For example:

        // persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
        //                      // and 4 has only one digit

        // persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
        //                       // 1*2*6 = 12, and finally 1*2 = 2

        // persistence(4) == 0 // because 4 is already a one-digit number
        #endregion
        public static int Persistence(long n)
        {
            // your code
            //if (n < 10)
            //{
            //    return 0;
            //}
            //int multi = 1;
            //listOfInts = new List<int>();
            //while (n > 0)
            //{
            //    listOfInts.Add(n % 10);
            //    n = n / 10;
            //}
            //for (int i = 0; i < listOfInts.Count; i++)
            //{
            //    multi = multi * listOfInts[i];
            //}
            //if (multi > 9)
            //{
            //    count++;
            //    Persistence(multi);
            //}
            //Console.WriteLine(multi);
            //Console.WriteLine(count);
            //return count;
            int count = 0;
            while (n > 9)
            {
                //xxx = n.ToString().Select(digit => int.Parse(digit.ToString()));
                //Console.WriteLine(n.ToString().Select(digit => int.Parse(digit.ToString())));
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
                Console.WriteLine(n);
            }
            return count;
        }

    }
}

