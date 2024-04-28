using System;


namespace Calculator;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! Welcome to  console calculator.\n");
        Console.WriteLine("Enter an expression in the format: number 1 operator number 2 (for example, 2 + 2)");
        Console.WriteLine("Supported operators: +, -, *, /");
        Console.WriteLine("To get the result after the expression, press equals(=)");
        Console.WriteLine("Press Esc to exit app");
        Console.WriteLine("Write an expression. If you made a mistake with your input, you can delete it by pressing the backspace button\n");

        OperationsWithCalculator  operation = new OperationsWithCalculator(); 

        while (true) { 
            //Отслеживаем что вводит пользователь и записываем результат в переменную
            var input = operation.GetExpressionFromUser();
           
            //Отслеживаем какая буджет операция и проверяем на ввод корректтного числа операторов.
           char op = operation.CheckWhatOperation(input);   
            if(op == ' ')
            {
                Console.WriteLine("\nInvalid expression.You need to write 2 numbers and only 1 operator");
                continue;
            }

            //Проводим математическую операцию и выводим в консоль
            operation.DoMathOperations(input, op);
        }

    }
}