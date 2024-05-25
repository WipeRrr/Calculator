using System.Globalization;

namespace Calculator;

class OperationsWithCalculator
{
   


    public double DoMathOperations(string input)
    {
        char op = Constants.opIsFalse;
        for (int i = 1; i < input.Length; i++)
        {
            if (Constants.Operators.Contains(input[i]) && (i == 1 || !Constants.Operators.Contains(input[i - 1])))
            {

                op = input[i];
                break;
            }
        }

        if (op == Constants.opIsFalse)
        {
            Console.WriteLine("\nInvalid expression. You need to write a valid expression.");
            return 0;
        }

        string[] parts = input.Split(op);

        double result = 0;
        double num2 = 0;
        double num1;
        if (!double.TryParse(parts[0].Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out num1) ||
            !double.TryParse(parts[1].Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
        {
            Console.WriteLine("Invalid expression. Incorrect number format.");
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
            case '^':
                result = Math.Pow(num1, num2);
                break;

        }
        return result;

    }

}