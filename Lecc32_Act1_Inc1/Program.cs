internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Christian Carrillo\n" +
            "Grado y Seccion: IVD\n" +
            "Clave: 3\n" +
            "CALCULADORA DE CONVERSIONES DE MEDIDA");

        Console.Write("Digite un valor en Metros: ");
        double metros=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nMenú Principal\n" +
            "1- Milimetros\n" +
            "2- Centimetros\n" +
            "3- Decimetros\n" +
            "4- Hectometros\n" + 
            "5- Kilometros\n" +
            "6- Salir");
        Console.Write("Digite una Opción: ");
        int opc=Convert.ToInt32(Console.ReadLine());

        double resultado;
        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("CONVERSOR A MILIMETROS");
                resultado = metros * 1000;
                Console.WriteLine("Los metros "+ metros+" en milimetros es: "+resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSOR A CENTIMETROS");
                resultado = metros * 100;
                Console.WriteLine("Los metros "+ metros+ " en centimetros es: "+ resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSOR A DECIMETROS");
                resultado = metros * 10;
                Console.WriteLine("Los metros "+ metros+ " en decimetros es: "+ resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("CONVERSOR A HECTOMETROS");
                resultado = metros / 100;
                Console.WriteLine("Los metros "+ metros+ " en hectometros es: "+ resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("CONVERSOR A KILOMETROS");
                resultado = metros / 1000;
                Console.WriteLine("Los metros "+ metros+ " en kilometros es: "+ resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Presione una tecla para Salir...");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Digite una Opción Válida");
                break;
        }
    }
}