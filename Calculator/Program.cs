namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to the console calculator.\n");
        Console.WriteLine("Enter an expression in the format: number 1 operator number 2 (for example, 2 + 2).\nTo perform an operation on a non-integer number, you must enter it with the \",\" or \".\" symbol.");
        Console.WriteLine("Supported operators: +, -, *, /,r(root,just write r after digit),%(remainder of division)");
        Console.WriteLine("To get the result after the expression, press equals(=)");
        Console.WriteLine("Press Esc to exit app");
        Console.WriteLine("Write an expression. If you made a mistake with your input, you can delete it by pressing the backspace button\n");
        ICalculator calculator;

        // Выбираем калькулятор на основе аргумента командной строки
        if (args.Length > 0 && args[0].Equals("basic", StringComparison.OrdinalIgnoreCase))
        {
            calculator = new BasicCalculator();
            Console.WriteLine("Running Basic Calculator...\nIn this version-Supported operators only: +, -, *, / ");
        }
        else
        {
            calculator = new ExtendedCalculator();
            Console.WriteLine("Running Extended Calculator...");
        }

        var getExpression = new ExpressionReceiver();

        while (true)
        {
            var input = getExpression.GetExpressionFromUser(calculator is ExtendedCalculator);
            var result = calculator.PerformOperation(input);
            Console.WriteLine(result);
        }
    }
}
