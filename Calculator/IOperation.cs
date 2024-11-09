

namespace Calculator
{
    internal interface IOperation
    {
        double PerformOperation(double num1, double num2);
    }

   
    internal class Addition : IOperation
    {
        public double PerformOperation(double num1, double num2) => num1 + num2;
    }

    internal class Subtraction : IOperation
    {
        public double PerformOperation(double num1, double num2) => num1 - num2;
    }

    internal class Multiplication : IOperation
    {
        public double PerformOperation(double num1, double num2) => num1 * num2;
    }

    internal class Division : IOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return num1 / num2;
        }
    }

    internal class Power : IOperation
    {
        public double PerformOperation(double num1, double num2) => Math.Pow(num1, num2);
    }

    internal class Root : IOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            if (num1 < 0) throw new InvalidOperationException("Cannot compute square root of a negative number.");
            return Math.Sqrt(num1);
        }
    }

    internal class Remainder : IOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return num1 % num2;
        }
    }
}
