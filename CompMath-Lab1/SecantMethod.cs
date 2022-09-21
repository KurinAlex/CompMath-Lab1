namespace CompMath_Lab1
{
    public class SecantMethod : IMethod
    {
        public SecantMethod(Writer writer)
        {
            _writer = writer;
        }

        public string Name => "Secant";

        public double Compute(Polynomial polynomial, double start, double end, double epsilon)
        {
            double a = start;
            double b = end;

            for (int i = 1; Math.Abs(b - a) >= epsilon || Math.Abs(polynomial.At(b)) >= epsilon; i++)
            {
                double left = Math.Min(a, b);
                double right = Math.Max(a, b);
                _writer.WriteLine($"{i} iteration: a = {left}, b = {right}, f(a) = {polynomial.At(left)}, f(b) = {polynomial.At(right)}");

                double valueAtA = polynomial.At(a);
                double valueAtB = polynomial.At(b);

                double tmp = b;
                b = (a * valueAtB - b * valueAtA) / (valueAtB - valueAtA);
                a = tmp;
            }

            return b;
        }

        private readonly Writer _writer;
    }
}
