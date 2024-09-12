
namespace Calculator
{
    public static class Constants
    {
       
        public enum Operators
        {
            Plus = '+',
            Minus = '-',
            Multiply = '*',
            Divide = '/',
            Power = '^',
            Root = 'r',
            Remainder = '%'
        }
        public static bool IsOperator(char c)
        {
            return Enum.IsDefined(typeof(Operators), (int)c);         
        }

        public static readonly char opIsFalse = '0';

        public static char[] BasicOperators => new[] { '+', '-', '*', '/' };

        public static char[] AllOperators => Enum.GetValues(typeof(Operators)).Cast<Operators>().Select(op => (char)op).ToArray();
    }
}