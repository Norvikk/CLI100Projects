namespace Projects
{
    internal static class ConvertTemperature
    {
        public static Func<double, double> FahrenheitToCelcius = Fahrenheit => Math.Round((Fahrenheit - 32) * .5556, 1);
        public static Func<double, double> CelciusToFahrenheit = Celsius => Math.Round(Celsius * 1.8 + 32, 1);
    }
}
