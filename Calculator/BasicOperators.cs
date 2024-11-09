

namespace Calculator
{
    public class BasicOperators
    {

        public char[] operators = { '+', '-', '*', '/' };
        public string GetOperators()
        {
            var value = "";
            for (int i = 0; i < operators.Length; i++)
            {
               
                if (i < operators.Length-1)
                {
                    value += operators[i] + ", ";
                }
                else value += operators[i]+ ".";
            }
            return value.ToString();
        }
    }
}