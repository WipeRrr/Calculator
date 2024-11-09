namespace Calculator.Outputter
{
    internal interface IOutputter
    {
        void WriteLine(string message);
        void Write(string message);
        void Write(char message);
    }
}
