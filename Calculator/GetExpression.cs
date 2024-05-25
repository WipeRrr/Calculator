using System;


namespace Calculator
{

    class GetExpression { 

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

            if (char.IsDigit(key.KeyChar) || Constants.Operators.Contains(key.KeyChar) || ",.".Contains(key.KeyChar))
            {

                input += key.KeyChar;
                Console.Write(key.KeyChar);
            }

        }
        return input;
    }
}
}
