using Calculator.Outputter;

namespace Calculator
{
    internal class CalculatorGreeting
    {

        private IOutputter Outputter { get; }

        internal CalculatorGreeting(IOutputter outputter)
        {
            Outputter = outputter;
        }

        public static void DisplayGreeting(IOutputter Outputter)
        {
            Outputter.WriteLine("Hello! Welcome to the console calculator.\n");
            Outputter.WriteLine("Enter an expression in the format: number 1 operator number 2 (for example, 2 + 2).\nTo perform an operation on a non-integer number, you must enter it with the \",\" or \".\" symbol.");
            Outputter.WriteLine("Supported operators: +, -, *, /,r(root,just write r after digit),%(remainder of division)");
            Outputter.WriteLine("To get the result after the expression, press equals(=)");
            Outputter.WriteLine("Press Esc to exit app");
            Outputter.WriteLine("Write an expression. If you made a mistake with your input, you can delete it by pressing the backspace button\n");
        }
    }
}
