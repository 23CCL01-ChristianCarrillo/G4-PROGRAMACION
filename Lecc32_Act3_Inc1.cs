using System;

class Program
{
    static void Main(string[] args)
    {
        double lado1, lado2, lado3;

        Console.WriteLine("Clasificador de Triangulos");
        Console.WriteLine();

        Console.Write("Ingrese el primer lado: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es Equilatero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triangulo es Isosceles.");
        }
        else
        {
            Console.WriteLine("El triangulo es Escaleno.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}