namespace Calculator.Outputter
{
    internal class ConsoleOutputter : IOutputter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public void Write(string message)
        {
            Console.Write(message);
        }
        public void Write(char message)
        {
            Console.Write(message);
        }
    }
}
