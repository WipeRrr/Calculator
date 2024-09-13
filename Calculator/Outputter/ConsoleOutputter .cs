namespace Calculator.Outputter
{
    public class ConsoleOutputter : IOutputter
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}
