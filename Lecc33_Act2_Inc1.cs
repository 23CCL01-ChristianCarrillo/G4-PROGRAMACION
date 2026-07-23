using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- INVERTIR FRASE ---");
        
        Console.Write("Ingrese una frase: ");
        string fraseOriginal = Console.ReadLine();

        char[] caracteres = fraseOriginal.ToCharArray();

        Array.Reverse(caracteres);

        string fraseInvertida = new string(caracteres);

        Console.WriteLine($"\nFrase invertida: {fraseInvertida}");
        
        Console.WriteLine("\n¡Programa finalizado!");
    }
}