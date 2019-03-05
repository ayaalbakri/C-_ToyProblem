using System;
using System.Linq;

namespace ToyProblem
{
    public class High
    {
        public static string HighestWord(string s)
        {
            #region
            //Given a string of words, you need to find the highest scoring word.

            //Each letter of a word scores points according to it's position in the alphabet: a = 1, b = 2, c = 3 etc.

            //You need to return the highest scoring word as a string.

            //If two words score the same, return the word that appears earliest in the original string.

            //All letters will be lowercase and all inputs will be valid.
            //int index = (int)c % 32;
            #endregion
            var xxx = s.Split(" ").Select(ch => ch.Select(cha => (int)cha % 32).Sum());
            int maxValue = xxx.Max();
            int maxIndex = xxx.ToList().IndexOf(maxValue);
            Console.WriteLine(xxx);
            var result = s.Split(" ")[maxIndex];
            Console.WriteLine(result);
            return result;
        }
    }
}
