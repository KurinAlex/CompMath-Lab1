namespace CompMath_Lab1
{
    public class Polynomial
    {
        public Polynomial(IEnumerable<double> coefficients) => _coefficients = coefficients;

        public double At(double x) => _coefficients.Select((a, i) => a * Math.Pow(x, i)).Sum();

        public Polynomial GetDerivative() => new(_coefficients.Select((a, i) => a * i).Skip(1));

        public override string ToString() => string.Join(" + ", _coefficients.Select((a, i) => $"{a} * x ^ {i}"));

        private readonly IEnumerable<double> _coefficients;
    }
}
