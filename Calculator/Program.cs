using Calculator.Outputter;

namespace Calculator;

class Program
{
    static void Main(string[] args)
{
        // Создаем аутпуттер
        IOutputter outputter = new ConsoleOutputter();

        // Выводим привественное сообщение
        CalculatorGreeting.DisplayGreeting(outputter);


        // Выбираем калькулятор на основе аргумента командной строки
        ICalculator calculator = args.Length > 0 && args[0].Equals("basic", StringComparison.OrdinalIgnoreCase)
              ? new BasicCalculator(outputter)
              : new ExtendedCalculator(outputter);

        // Выводим сообщение какой калькулятор выбран
        outputter.WriteLine(calculator is BasicCalculator ? "Running Basic Calculator...\nIn this version-Supported operators only: +, -, *, / " : "Running Extended Calculator...");

        // Запускаем отслеживание ввода пользователем
        var getExpression = new ExpressionReceiver(outputter);

        while (true)
        {
            var input = getExpression.GetExpressionFromUser(calculator is ExtendedCalculator);
            var result = calculator.PerformOperation(input);
            outputter.WriteLine(result.ToString());
        }
    }
}
