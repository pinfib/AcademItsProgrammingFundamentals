namespace Academits.Dorosh
{
    public class Range
    {
        private const double Epsilon = 1.0e-10;

        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        private static bool IsLargerOrEqual(double a, double b)
        {
            return a - b >= -Epsilon;
        }

        private static bool IsSmallerOrEqual(double a, double b)
        {
            return a - b <= Epsilon;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return IsLargerOrEqual(number, From) && IsSmallerOrEqual(number, To);
        }
    }
}