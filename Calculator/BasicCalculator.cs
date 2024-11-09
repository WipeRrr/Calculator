

using Calculator.Outputter;

namespace Calculator
{
    internal class BasicCalculator : ICalculator
    {

        private readonly OperationsWithCalculator _operations;
        private IOutputter Outputter { get; }

        internal BasicCalculator(IOutputter outputter)
        {
            Outputter = outputter;
            _operations = new OperationsWithCalculator(Outputter);
        }


        //private readonly OperationsWithCalculator _operations = new OperationsWithCalculator(Outputter);
        //private IOutputter  Outputter {get;}
        //internal BasicCalculator(IOutputter outputter)
        //{
        //    Outputter = outputter;  
        //}

        public double PerformOperation(string input)
        {
            
            char[] allowedOperators = { '+', '-', '*', '/' };

            return _operations.DoMathOperations(input, allowedOperators);
        }
    }
}
