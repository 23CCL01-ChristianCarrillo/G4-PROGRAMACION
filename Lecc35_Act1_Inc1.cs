using System;

class Program
{
    static void Main(string[] args)
    {
        char continuar = 's';
        double tasaDolar = 0.13;     
        double tasaEuro = 0.12;     
        double tasaPesoMex = 2.25;  
        double tasaYen = 20.50;     
        double tasaLibra = 0.10;    

        while (continuar == 's' || continuar == 'S')
        {
            Console.Clear();
            Console.WriteLine("--- CONVERSOR DE MONEDA ---");
            Console.Write("Ingrese la cantidad en moneda local: ");

            if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad >= 0)
            {
                double dolares = cantidad * tasaDolar;
                double euros = cantidad * tasaEuro;
                double pesosMx = cantidad * tasaPesoMex;
                double yenes = cantidad * tasaYen;
                double libras = cantidad * tasaLibra;

                Console.WriteLine("\n--- EQUIVALENTES EN 5 PAÍSES ---");
                Console.WriteLine($"1. Estados Unidos (Dólares): $ {dolares:F2}");
                Console.WriteLine($"2. Europa (Euros):          € {euros:F2}");
                Console.WriteLine($"3. México (Pesos mexicanos): $ {pesosMx:F2}");
                Console.WriteLine($"4. Japón (Yenes japoneses):  ¥ {yenes:F2}");
                Console.WriteLine($"5. Reino Unido (Libras):     £ {libras:F2}");
            }
            else
            {
                Console.WriteLine("\nError: Por favor, ingrese una cantidad numérica válida.");
            }

            Console.Write("\n¿Desea convertir otra cantidad? (s/n): ");
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        Console.WriteLine("\n¡Programa finalizado!");
    }
}