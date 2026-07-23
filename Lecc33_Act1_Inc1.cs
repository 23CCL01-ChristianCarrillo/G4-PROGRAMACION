using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaración de los arreglos para almacenar 10 nombres y 10 teléfonos
        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("--- REGISTRO DE AGENDA TELEFÓNICA (10 PERSONAS) ---");

        // Ciclo para capturar los datos de las 10 personas
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nPersona {i + 1}:");
            
            Console.Write("Ingrese el nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Ingrese el teléfono: ");
            telefonos[i] = Console.ReadLine();
        }

        char continuar = 's';

        // Ciclo para realizar consultas por posición
        while (continuar == 's' || continuar == 'S')
        {
            Console.Clear();
            Console.WriteLine("--- CONSULTA DE AGENDA ---");
            Console.Write("Ingrese el número de posición que desea consultar (0 al 9): ");
            
            if (int.TryParse(Console.ReadLine(), out int posicion))
            {
                // Validar que la posición esté dentro del rango del arreglo
                if (posicion >= 0 && posicion < 10)
                {
                    Console.WriteLine("\n--- DATOS ENCONTRADOS ---");
                    Console.WriteLine($"Posición: {posicion}");
                    Console.WriteLine($"Nombre:   {nombres[posicion]}");
                    Console.WriteLine($"Teléfono: {telefonos[posicion]}");
                }
                else
                {
                    Console.WriteLine("\nError: La posición ingresada no existe. Debe ser un número entre 0 y 9.");
                }
            }
            else
            {
                Console.WriteLine("\nError: Por favor, ingrese un número válido.");
            }

            Console.Write("\n¿Desea consultar otra posición? (s/n): ");
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        Console.WriteLine("\n¡Programa finalizado!");
    }
}