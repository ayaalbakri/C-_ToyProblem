using System;
using System.Linq;

namespace ToyProblem
{
    public class DuplicateEncode
    {
        //The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

        //Examples:

        //"din" => "((("

        //"recede" => "()()()"

        //"Success" => ")())())"

        //"(( @" => "))(("
        public static string DuplicateEncodeChar(string word)
        {
            string encodeChar = "";
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Count(ch => ch == word[i]) > 1)
                {
                    encodeChar += ")";
                }
                else
                {
                    encodeChar += "(";
                }
            }

            var xxx = word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray();
            //var trrry = word.Select(ch => word.Count(ele => ele == ch)==1);
            Console.WriteLine(encodeChar);

            return encodeChar;
        }
    }
}
