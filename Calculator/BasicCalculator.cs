

namespace Calculator
{
    internal class BasicCalculator : ICalculator
    {
        private readonly OperationsWithCalculator _operations = new OperationsWithCalculator();

        public double PerformOperation(string input)
        {
            
            char[] allowedOperators = { '+', '-', '*', '/' };

            return _operations.DoMathOperations(input, allowedOperators);
        }
    }
}
