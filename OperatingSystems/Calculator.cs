using System;

namespace OperatingSystemTests
{
    public class Calculator
    {
        public object Add(string num1, string num2)
        {
            int.TryParse(num1, out var number1);
            int.TryParse(num2, out var number2);
            return number1 + number2;
        }
    }
}