using Calculator.Outputter;

namespace Calculator
{
    internal class ExtendedCalculator : ICalculator
    {


        private readonly OperationsWithCalculator _operations;
        private IOutputter Outputter { get; }
        private char[] _allowedOperators { get; }
        internal ExtendedCalculator(IOutputter outputter, char[] allowedOperators)
        {
            Outputter = outputter;
            _operations = new OperationsWithCalculator(Outputter);
            _allowedOperators = allowedOperators;
        }

        public double PerformOperation(string input)
        {
            return _operations.DoMathOperations(input, _allowedOperators);
        }
    }
}
