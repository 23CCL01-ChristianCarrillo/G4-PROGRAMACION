using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("--- CONVERSOR DE NÚMEROS ---");
            Console.WriteLine("1. Decimal a Binario");
            Console.WriteLine("2. Binario a Decimal");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción (1-3): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--- DECIMAL A BINARIO ---");
                        Console.Write("Ingrese un número decimal entero: ");
                        if (int.TryParse(Console.ReadLine(), out int decimalNum))
                        {
                            if (decimalNum >= 0)
                            {
                                string binario = Convert.ToString(decimalNum, 2);
                                Console.WriteLine($"\nEl número binario es: {binario}");
                            }
                            else
                            {
                                Console.WriteLine("\nPor favor, ingrese un número entero positivo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nError: Entrada no válida.");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- BINARIO A DECIMAL ---");
                        Console.Write("Ingrese un número binario (ej. 1010): ");
                        string binarioStr = Console.ReadLine();
                        try
                        {
                            int decimalResult = Convert.ToInt32(binarioStr, 2);
                            Console.WriteLine($"\nEl número decimal es: {decimalResult}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nError: El texto ingresado no es un número binario válido (solo se permiten 0s y 1s).");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nError: El número binario es demasiado largo.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n¡Saliendo del programa!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPor favor, ingrese un número válido.");
            }

            if (opcion != 3)
            {
                Console.Write("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 3);
    }
}