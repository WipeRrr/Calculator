using Calculator.Outputter;

namespace Calculator
{
    internal class ExtendedCalculator : ICalculator
    {


        private readonly OperationsWithCalculator _operations;
        private IOutputter Outputter { get; }

        internal ExtendedCalculator(IOutputter outputter)
        {
            Outputter = outputter;
            _operations = new OperationsWithCalculator(Outputter);
        }

        public double PerformOperation(string input)
        {
            return _operations.DoMathOperations(input);
        }
    }
}
