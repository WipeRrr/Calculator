using System.Globalization;

namespace Calculator;

class OperationsWithCalculator
{
   


    public double DoMathOperations(string input)
    {
        char op = Constants.opIsFalse;
        int opIndex = -1;
        for (int i = 1; i < input.Length; i++)
        {
            if (Constants.IsOperator(input[i]) && (i == 1 || !Constants.IsOperator(input[i - 1])))
            {
                opIndex = i;
                op = input[i];
                break;
            }
        }

        if (op == Constants.opIsFalse)
        {
            Console.WriteLine("\nInvalid expression. You need to write a valid expression.");
            return 0;
        }

        // –азделение строки с учетом отрицательных чисел
        string firstPart = input.Substring(0, opIndex);
        string secondPart = input.Substring(opIndex + 1);

        double result = 0;
        double num2 = 0;
        double num1;
        if (!double.TryParse(firstPart.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out num1) ||
            !double.TryParse(secondPart.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
        {
            Console.WriteLine("Invalid expression. Incorrect number format.");
            result = double.NaN;
        }

        switch (op)
        {

            case (char)Constants.Operators.Plus:
                result = num1 + num2;
                break;

            case (char)Constants.Operators.Minus:
                result = num1 - num2;
                break;

            case (char)Constants.Operators.Divide:
                if (num2 == 0)
                {
                    Console.WriteLine("You can't divide by 0.Try again.");

                }
                result = num1 / num2;
                break;

            case (char)Constants.Operators.Multiply:
                result = num1 * num2;
                break;
            case (char)Constants.Operators.Power:
                result = Math.Pow(num1, num2);
                break;

        }
        return result;

    }

}