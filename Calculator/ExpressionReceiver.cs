using Calculator.Outputter;
using System;


namespace Calculator
{

    internal class ExpressionReceiver {

        private IOutputter Outputter { get; }
        internal ExpressionReceiver(IOutputter outputter)

        {
            Outputter = outputter;
        }

        public string GetExpressionFromUser(Constants constants, bool allowExtendedOperators = false)
    {
        var input = "";

        var allowedOperators = allowExtendedOperators
               ? constants.AllOperators
               : constants.BasicOperators;

            while (true)
        {
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                    Outputter.WriteLine("\nThank you for using the calculator!\u263A");
                Environment.Exit(0);
            }
            if (key.Key == ConsoleKey.Enter)
            {
                    Outputter.Write("=");
                break;
            }

            if (key.KeyChar == '=')
            {
                    Outputter.Write("=");
                break;
            }

            if (key.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                    Outputter.Write("\b \b");
            }


                if (char.IsDigit(key.KeyChar) || ",.".Contains(key.KeyChar) ||
                         (allowedOperators.Contains(key.KeyChar) && !",.".Contains(key.KeyChar)))
                {

                input += key.KeyChar;
                    Outputter.Write(key.KeyChar);
            }

        }
            return input;

    }

}

}
