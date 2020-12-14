using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit
{
    public class Calculator
    {
        public Dictionary<int, Func<double, double, double>> culcFunctions;

        public Calculator()
        {
            culcFunctions = new Dictionary<int, Func<double, double, double>>();
            culcFunctions.Add(1, new Func<double, double, double>(Sum));
            culcFunctions.Add(2, new Func<double, double, double>(Diff));
            culcFunctions.Add(3, new Func<double, double, double>(Multiply));
            culcFunctions.Add(4, new Func<double, double, double>(Mod));
            culcFunctions.Add(5, new Func<double, double, double>(Div));
            culcFunctions.Add(6, new Func<double, double, double>(Pow));
        }

        double Sum(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        double Diff(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        double Mod(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException();
            }
            return firstValue % secondValue;
        }

        double Div(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException();
            }
            return firstValue / secondValue;
        }

        double Pow(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
