using System;
using System.Linq;

namespace ToyProblem
{
    public class ValidatePin
    {
        public static bool ValidatePinMethod(string pin)
        {
            //pin.Count(el => int.Parse(el.ToString()) < 10);
            //Char.IsDigit(a)
            return pin.Length == 4 || pin.Length == 6 && pin.All(n => Char.IsDigit(n));
        }
    }
}
