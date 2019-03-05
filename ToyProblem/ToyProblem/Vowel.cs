using System.Linq;

namespace ToyProblem
{
    public class Vowel
    {
        public static int GetVowelCount(string str)
        {
            //var isE = str.Contains("e");
            // str.Count(ele => "aeiouAEIOU".Contains(ele));
            str.ToLower();
            int vowelCount = 0;
            //a, e, i, o, and u
            vowelCount = str.Count(ele => ele == 'a' || ele == 'e' || ele == 'i' || ele == 'o' || ele == 'u');
            return vowelCount;
        }
    }
}
