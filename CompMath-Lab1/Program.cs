namespace CompMath_Lab1
{
    public class Program
    {
        const int listN = 15;
        const int groupN = 11;

        const int variantN = ((listN - 1) % 10) + 1;
        const int k = ((groupN - 1) % 10) + 1;
        const int a = (listN - ((listN - 1) % 10) - 1) / 10;

        const double epsilon = 0.00001;

        static readonly double[] coefficients = { 2 * (1 + a), -3, -1, 0, 0, 3 * k };
        static readonly Polynomial polynomial = new(coefficients.Reverse());
        static readonly (double, double)[] ranges = { (-1.75, -0.482) };

        const string fileName = "Result.txt";

        static void Main(string[] args)
        {
            using (StreamWriter fileWriter = new(fileName))
            {
                Writer writer = new(fileWriter);
                IMethod[] methods = { new BisectionMethod(writer), new SecantMethod(writer), new NewtonMethod(writer) };

                writer.WriteDivider();
                writer.WriteLine($"Variant: {variantN}");
                writer.WriteLine($"Polynomial: f(x) = {polynomial}");
                writer.WriteLine($"Epsilon: {epsilon}");
                writer.WriteDivider();

                foreach (var range in ranges)
                {
                    writer.WriteLine($"Finding root in range {range}");
                    writer.WriteDivider();

                    foreach (IMethod method in methods)
                    {
                        writer.WriteLine($"{method.Name} method:");
                        writer.WriteLine($"Result: {method.Compute(polynomial, range.Item1, range.Item2, epsilon)}");
                        writer.WriteDivider();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}