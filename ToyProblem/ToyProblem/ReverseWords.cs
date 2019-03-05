using System;
using System.Linq;

namespace ToyProblem
{
    public class ReverseWords
    {
        // string vcvcvcvc = "hi";
        //var re = String.Join("", vcvcvcvc.Reverse());
        //Console.Write(re);
        public static string ReverseWordsMethod(string str)
        {
            //Write your code here
            //Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

            //            Examples
            //"This is an example!" ==> "sihT si na !elpmaxe"
            //"double  spaces" ==> "elbuod  secaps"
            var listOfWords = str.Split(" ");
            var newList = listOfWords.Select(word => String.Join("", word.Reverse()));
            string rev = string.Join(" ", newList);
            return rev;
        }
    }
}
