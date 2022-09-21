namespace CompMath_Lab1
{
    public class NewtonMethod : IMethod
    {
        public NewtonMethod(Writer writer)
        {
            _writer = writer;
        }

        public string Name => "Newton";

        public double Compute(Polynomial polynomial, double start, double end, double epsilon)
        {
            double x1 = start;
            double x2 = end;
            Polynomial derivative = polynomial.GetDerivative();

            for (int i = 1; Math.Abs(x2 - x1) >= epsilon || Math.Abs(polynomial.At(x2)) >= epsilon; i++)
            {
                x1 = x2;
                x2 = x1 - polynomial.At(x1) / derivative.At(x1);
                
                _writer.WriteLine($"{i} iteration: x = {x2}, f(x) = {polynomial.At(x2)}");
            }

            return x2;
        }

        private readonly Writer _writer;
    }
}
