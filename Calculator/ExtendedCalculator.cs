namespace Calculator
{
    internal class ExtendedCalculator : ICalculator
    {
        private readonly OperationsWithCalculator _operations = new OperationsWithCalculator();

        public double PerformOperation(string input)
        {
            return _operations.DoMathOperations(input);
        }
    }
}
