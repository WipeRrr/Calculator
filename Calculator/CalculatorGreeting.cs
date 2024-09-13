namespace Calculator
{
    internal class CalculatorGreeting
    {
        public static void DisplayGreeting()
        {
        Console.WriteLine("Hello! Welcome to the console calculator.\n");
        Console.WriteLine("Enter an expression in the format: number 1 operator number 2 (for example, 2 + 2).\nTo perform an operation on a non-integer number, you must enter it with the \",\" or \".\" symbol.");
        Console.WriteLine("Supported operators: +, -, *, /,r(root,just write r after digit),%(remainder of division)");
        Console.WriteLine("To get the result after the expression, press equals(=)");
        Console.WriteLine("Press Esc to exit app");
        Console.WriteLine("Write an expression. If you made a mistake with your input, you can delete it by pressing the backspace button\n");
        }
    }
}
