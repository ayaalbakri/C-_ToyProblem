using System.Linq;

namespace ToyProblem
{
    public class Phone
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            //(111) 111-1111
            //array.Skip(3).Take(5)
            //var xxxx = numbers.Skip(3).Take(numbers.Length);
            //var phoneToString = "(" + numbers[0] + numbers[1] + numbers[2] + ")" + numbers.Skip(3).Take(numbers.Length).ToString();
            var result = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
            return result;
        }
    }
}
