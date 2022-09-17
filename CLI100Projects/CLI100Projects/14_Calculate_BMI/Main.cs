namespace Projects
{
    internal static class CalculateBMI
    {
        public static double Calculate(double height, double weight) => Math.Round((weight / (height / 100 * height / 100)), 1);
    }
}
