namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(54);
            Console.WriteLine($"55 Fahrenheit is {celsius} degree celsius");
            var Fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"it is {Fahrenheit} converted back");
        }
    }
}
