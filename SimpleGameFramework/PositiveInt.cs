using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework
{
    public class PositiveInt
    {
        private const int defaultLowerLimit = 0;
        public int Value { get; }

        // This method makes it possible for no accessibility for number that is lower than zero.
        public PositiveInt(int value, int lowerLimit = defaultLowerLimit)
        {
            if (value < lowerLimit)
            {
                throw new ArgumentException($"Value {value} is below limit of {lowerLimit}");
            }

            Value = value;
        }

        // Here is where Operator is used, so that a PositiveInt can be used for subtraction.
        public static PositiveInt operator -(PositiveInt pi, int value)
        {
            return new PositiveInt(pi.Value - value);
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
