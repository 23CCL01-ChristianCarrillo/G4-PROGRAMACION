using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CALCULADORA DE ÍNDICE DE MASA CORPORAL (IMC) ---");

        Console.Write("Ingrese su peso en kg (ej. 70.5): ");
        if (double.TryParse(Console.ReadLine(), out double peso) && peso > 0)
        {
            Console.Write("Ingrese su altura en metros (ej. 1.75): ");
            if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
            {
                double imc = peso / (altura * altura);

                Console.WriteLine($"\nSu Índice de Masa Corporal (IMC) es: {imc:F2}");

                Console.Write("Clasificación: ");
                if (imc < 18.5)
                {
                    Console.WriteLine("Bajo peso");
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    Console.WriteLine("Peso normal (saludable)");
                }
                else if (imc >= 25 && imc < 30)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else
                {
                    Console.WriteLine("Obesidad");
                }
            }
            else
            {
                Console.WriteLine("\nError: Ingrese una altura válida mayor a 0.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Ingrese un peso válido mayor a 0.");
        }

        Console.WriteLine("\n¡Programa finalizado!");
    }
}