namespace CompMath_Lab1
{
    public class Writer
    {
        public Writer(StreamWriter fileWriter) => _fileWriter = fileWriter;

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
            _fileWriter.WriteLine(line);
        }

        public void WriteDivider()
        {
            WriteLine(new string('-', _dividerLength));
        }

        private readonly StreamWriter _fileWriter;
        private const int _dividerLength = 100;
    }
}
