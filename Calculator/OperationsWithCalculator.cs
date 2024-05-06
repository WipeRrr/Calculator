namespace Calculator;

class OperationsWithCalculator
{
    public string GetExpressionFromUser()
    {
        var input = "";

        while (true)
        {
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\nThank you for using the calculator!\u263A");
                Environment.Exit(0);
            }
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Write("=");
                break;
            }

            if (key.KeyChar == '=')
            {
                Console.Write("=");
                break;
            }

            if (key.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                Console.Write("\b \b");
            }

            if (char.IsDigit(key.KeyChar) || "+-*/".Contains(key.KeyChar))
            {

                input += key.KeyChar;
                Console.Write(key.KeyChar);
            }

        }
        return input;
    }

    public char CheckWhatOperation(string input)
    {

        char[] operators = { '+', '-', '*', '/' };
        char op = '0';

        foreach (char symbol in operators)
        {
            if (input.Contains(symbol))
            {

                op = symbol;
                break;
            }
        }

        byte operatorCount = 0;
        foreach (char c in input)
        {
            if (c == operators[0] || c == operators[1] || c == operators[2] || c == operators[3])
            {
                operatorCount++;

            }

        }
        if (operatorCount != 1)
        {
            return ' ';
        }

        return op;
    }
    public double DoMathOperations(string input)
    {
        var op = CheckWhatOperation(input);
        if (op == ' ')
        {
            Console.WriteLine("\nInvalid expression.You need to write 2 numbers and only 1 operator");
            return 0;
        }
        string[] parts = input.Split(op);
        double result = 0;
        double num1 = 0;
        double num2 = 0;
        if (!double.TryParse(parts[0], out num1) || !double.TryParse(parts[1], out num2))
        {
            Console.WriteLine("Invalid expression.Incorrect number format.");
            result = double.NaN;
        }


        switch (op)
        {

            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("You can't divide by 0.Try again.");

                }
                result = num1 / num2;
                break;

            case '*':
                result = num1 * num2;
                break;

        }
        return result;

    }

}