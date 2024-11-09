using static Calculator.Constants;

namespace Calculator
{
    public  class Constants
    {
        public static readonly char opIsFalse = '0';


        public  char[] BasicOperators = { '+', '-', '*', '/' };

        public  char[] AllOperators => Enum.GetValues(typeof(Operators)).Cast<Operators>().Select(op => (char)op).ToArray();


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

        public  string GetBasicOperators()
        {
            var value = "";
            for (int i = 0; i < BasicOperators.Length; i++)
            {

                if (i < BasicOperators.Length - 1)
                {
                    value += BasicOperators[i] + ", ";
                }
                else value += BasicOperators[i] + ".";
            }
            return value.ToString();
        }
        public static bool IsOperator(char c)
        {
            return Enum.IsDefined(typeof(Operators), (int)c);         
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

    }
}