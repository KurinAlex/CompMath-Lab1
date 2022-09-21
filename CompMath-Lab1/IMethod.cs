namespace CompMath_Lab1
{
    public interface IMethod
    {
        string Name { get; }
        double Compute(Polynomial polynomial, double start, double end, double epsilon);
    }
}
