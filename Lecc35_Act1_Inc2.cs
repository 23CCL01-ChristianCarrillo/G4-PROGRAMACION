using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CALCULADORA DE CAMBIO ---");

        Console.Write("Ingrese el precio del producto: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal precio) && precio >= 0)
        {
            Console.Write("Ingrese con cuánto pagó el cliente: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal pago) && pago >= precio)
            {
                decimal cambioTotal = pago - precio;
                Console.WriteLine($"\nCambio total a devolver: ${cambioTotal:F2}");

                int cambio = (int)Math.Round(cambioTotal);

                int b200 = cambio / 200;
                cambio %= 200;

                int b100 = cambio / 100;
                cambio %= 100;

                int b50 = cambio / 50;
                cambio %= 50;

                int b20 = cambio / 20;
                cambio %= 20;

                int monedas = cambio;

                Console.WriteLine("\n--- DESGLOSE DEL CAMBIO ---");
                Console.WriteLine($"Billetes de 200: {b200}");
                Console.WriteLine($"Billetes de 100: {b100}");
                Console.WriteLine($"Billetes de 50:  {b50}");
                Console.WriteLine($"Billetes de 20:  {b20}");
                Console.WriteLine($"Monedas:         {monedas}");
            }
            else
            {
                Console.WriteLine("\nError: El monto pagado es menor al precio o no es válido.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Por favor, ingrese un precio válido.");
        }

        Console.WriteLine("\n¡Programa finalizado!");
    }
}