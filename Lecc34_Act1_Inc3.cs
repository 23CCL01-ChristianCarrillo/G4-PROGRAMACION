using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CONVERSOR DE TEMPERATURA ---");

        Console.Write("Ingrese la cantidad en grados centígrados (°C): ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"a. Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"b. Celsius:    {celsius:F2} °C");
            Console.WriteLine($"c. Kelvin:     {kelvin:F2} K");
        }
        else
        {
            Console.WriteLine("\nError: Por favor, ingrese un valor numérico válido.");
        }

        Console.WriteLine("\n¡Programa finalizado!");
    }
}