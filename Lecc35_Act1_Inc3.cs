using System;

class Program
{
    static void Main(string[] args)
    {
        char jugarDeNuevo = 's';
        Random random = new Random();

        while (jugarDeNuevo == 's' || jugarDeNuevo == 'S')
        {
            Console.Clear();
            Console.WriteLine("--- PIEDRA, PAPEL O TIJERAS ---");
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Su elección (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int opcionUsuario) && opcionUsuario >= 1 && opcionUsuario <= 3)
            {
                string[] opciones = { "Piedra", "Papel", "Tijeras" };
                string eleccionUsuarioStr = opciones[opcionUsuario - 1];

                int opcionComputadora = random.Next(1, 4);
                string eleccionComputadoraStr = opciones[opcionComputadora - 1];

                Console.WriteLine($"\nUsted eligió: {eleccionUsuarioStr}");
                Console.WriteLine($"La computadora eligió: {eleccionComputadoraStr}");

                Console.WriteLine("\n--- RESULTADO ---");

                if (opcionUsuario == opcionComputadora)
                {
                    Console.WriteLine("¡Empate!");
                }
                else if ((opcionUsuario == 1 && opcionComputadora == 3) ||
                         (opcionUsuario == 2 && opcionComputadora == 1) || 
                         (opcionUsuario == 3 && opcionComputadora == 2))   
                {
                    Console.WriteLine("¡Felicidades, usted ha ganado!");
                }
                else
                {
                    Console.WriteLine("¡La computadora ha ganado!");
                }
            }
            else
            {
                Console.WriteLine("\nError: Opción no válida. Debe elegir un número entre 1 y 3.");
            }

            Console.Write("\n¿Desea jugar de nuevo? (s/n): ");
            jugarDeNuevo = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        Console.WriteLine("\n¡Gracias por jugar!");
    }
}