namespace Calculator.Outputter
{
    internal class ConsoleOutputter : IOutputter
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}
