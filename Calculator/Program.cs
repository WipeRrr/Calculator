using Calculator.Outputter;

namespace Calculator;

class Program
{
    static void Main(string[] args)
{    
        // Выводим привественное сообщение
        CalculatorGreeting.DisplayGreeting();

        // Создаем аутпуттер
        IOutputter outputter = new ConsoleOutputter();

        // Выбираем калькулятор на основе аргумента командной строки
        ICalculator calculator = args.Length > 0 && args[0].Equals("basic", StringComparison.OrdinalIgnoreCase)
              ? new BasicCalculator()
              : new ExtendedCalculator();

        // Выводим сообщение какой калькулятор выбран
        Console.WriteLine(calculator is BasicCalculator ? "Running Basic Calculator...\nIn this version-Supported operators only: +, -, *, / " : "Running Extended Calculator...");

        // Запускаем отслеживание ввода пользователем
        var getExpression = new ExpressionReceiver();

        while (true)
        {
            var input = getExpression.GetExpressionFromUser(calculator is ExtendedCalculator);
            var result = calculator.PerformOperation(input);
            outputter.Output(result.ToString());
        }
    }
}
