namespace CompMath_Lab1
{
    public abstract class Method
    {
        public Method(Writer writer) => _writer = writer;

        public abstract string Name { get; }
        public abstract double Compute(Polynomial polynomial, double start, double end, double epsilon);

        protected Writer _writer;
    }
}
