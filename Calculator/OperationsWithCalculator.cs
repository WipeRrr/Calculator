using System.Globalization;

namespace Calculator;

internal class OperationsWithCalculator
{
    public double DoMathOperations(string input, char[] allowedOperators = null)
    {
        char op = Constants.opIsFalse;
        int opIndex = -1;
        for (int i = 1; i < input.Length; i++)
        {
            if (allowedOperators == null || allowedOperators.Contains(input[i]))
            {

                if (Constants.IsOperator(input[i]) && (i == 1 || !Constants.IsOperator(input[i - 1])))
                {
                    opIndex = i;
                    op = input[i];
                    break;
                }
            }
        }

        if (op == Constants.opIsFalse || opIndex == -1)
        {
            Console.WriteLine("\nInvalid expression. You need to write a valid expression.");
            return double.NaN;
        }

        // –азделение строки с учетом отрицательных чисел
        string firstPart = input.Substring(0, opIndex);
        string secondPart = input.Substring(opIndex + 1);

       
        double num1, num2 = 0;
        if (!double.TryParse(firstPart.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out num1) ||
            op != (char)Constants.Operators.Root && !double.TryParse(secondPart.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
        {
            Console.WriteLine("Invalid expression. Incorrect number format.");
            return double.NaN;
        }

        IOperation operation = op switch
        {
            (char)Constants.Operators.Plus => new Addition(),
            (char)Constants.Operators.Minus => new Subtraction(),
            (char)Constants.Operators.Multiply => new Multiplication(),
            (char)Constants.Operators.Divide => new Division(),
            (char)Constants.Operators.Power => new Power(),
            (char)Constants.Operators.Root => new Root(),
            (char)Constants.Operators.Remainder => new Remainder(),
            _ => throw new InvalidOperationException("Invalid operation.")
        };

        try
        {
            return operation.PerformOperation(num1, num2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN;
        }

    }

}