using System;


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
    }
}