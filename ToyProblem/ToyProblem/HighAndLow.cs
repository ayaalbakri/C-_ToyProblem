using System;
using System.Linq;

namespace ToyProblem
{
    public class HighAndLow
    {
        public static string HighAndLowNumber(string numbers)
        {
            // Code here or
            //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
            string highLow = "";
            //remove space
            var listOfNumbers = numbers.Trim().Select(c => int.Parse(c.ToString()));
            var high = listOfNumbers.Max();
            var low = listOfNumbers.Min();
            highLow += high + " " + low;
            Console.WriteLine(highLow);
            

            return highLow;
        }
    }
}
