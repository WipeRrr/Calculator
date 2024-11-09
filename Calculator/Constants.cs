
using static Calculator.Constants;

namespace Calculator
{
    public  class Constants
    {
        public static readonly char opIsFalse = '0';

        public static char[] BasicOperators =  new BasicOperators().operators;


        public static char[] AllOperators => Enum.GetValues(typeof(Operators)).Cast<Operators>().Select(op => (char)op).ToArray();


    public string GetAllOperators()

        {
            var value = "";
            for (int i = 0; i < AllOperators.Length; i++)
            {
                if (i < AllOperators.Length - 1)
                {
                    value += AllOperators[i] + ", ";
                }
                else value += AllOperators[i]+ ".";
            }
            return value.ToString();
        }
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

      
    }
}