namespace CompMath_Lab1
{
    public class BisectionMethod : Method
    {
        public BisectionMethod(Writer writer) : base(writer)
        {
        }

        public override string Name => "Bisection";

        public override double Compute(Polynomial polynomial, double start, double end, double epsilon)
        {
            double a = start;
            double b = end;
            double c = start;

            for (int i = 1; Math.Abs(b - a) >= epsilon || Math.Abs(polynomial.At(c)) >= epsilon; i++)
            {
                double left = Math.Min(a, b);
                double right = Math.Max(a, b);
                _writer.WriteLine($"{i} iteration: a = {left}, b = {right}, f(a) = {polynomial.At(left)}, f(b) = {polynomial.At(right)}");

                c = (a + b) / 2;

                if (Math.Sign(polynomial.At(c)) == Math.Sign(polynomial.At(a)))
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
            }
            return c;
        }
    }
}
