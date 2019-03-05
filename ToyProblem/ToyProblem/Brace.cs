using System;

namespace ToyProblem
{
    public class Brace
    {
        public static bool validBraces(String braces)
        {
            //var countparanthesis = 0;
            var paranthesisLeft = 0;
            var paranthesisRight = 0;
            var sequreLeft = 0;
            var sequreRight = 0;
            var curlyLeft = 0;
            var curlyRight = 0;
            for (int i = 0; i < braces.Length; i++)
            {

                if (braces[i] == '(')
                {
                    paranthesisRight++;
                }
                if (braces[i] == ')')
                {
                    paranthesisLeft++;
                }
                if (braces[i] == '{')
                {
                    curlyRight++;
                }
                if (braces[i] == '}')
                {
                    curlyLeft++;
                }
                if (braces[i] == '[')
                {
                    sequreRight++;
                }
                if (braces[i] == ']')
                {
                    sequreLeft++;
                }
                if (paranthesisLeft > paranthesisRight || curlyLeft > curlyRight || sequreLeft > sequreRight)
                {
                    return false;
                }
            }
            var bol = paranthesisRight == paranthesisLeft && sequreRight == sequreLeft && curlyRight == curlyLeft;
            return paranthesisRight == paranthesisLeft && sequreRight == sequreLeft && curlyRight == curlyLeft;
        }
    }
}
