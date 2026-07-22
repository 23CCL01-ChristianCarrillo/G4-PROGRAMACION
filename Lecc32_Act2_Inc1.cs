using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Signo zodiacal y Horóscopo");
        Console.WriteLine();

        Console.Write("Ingresa tu mes de nacimiento del 1 al 12: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa tu día de nacimiento: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        string signo = "";
        string horoscopo = "";

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries";
            horoscopo = "Hoy será un excelente día para comenzar nuevos proyectos.";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro";
            horoscopo = "La paciencia te ayudará a alcanzar tus metas.";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Géminis";
            horoscopo = "Una buena noticia llegará muy pronto.";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cáncer";
            horoscopo = "Comparte más tiempo con tu familia y amigos.";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo";
            horoscopo = "Tu liderazgo será reconocido por los demás.";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo";
            horoscopo = "Organizar tus tareas te dará excelentes resultados.";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra";
            horoscopo = "Mantén el equilibrio y evita discusiones innecesarias.";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio";
            horoscopo = "Confía en tu intuición para tomar decisiones.";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario";
            horoscopo = "Una oportunidad inesperada aparecerá pronto.";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio";
            horoscopo = "El esfuerzo de hoy traerá recompensas mañana.";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario";
            horoscopo = "Tu creatividad te abrirá nuevas puertas.";
        }
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
        {
            signo = "Piscis";
            horoscopo = "Escucha tu corazón y mantén una actitud positiva.";
        }
        else
        {
            Console.WriteLine("La fecha ingresada no es válida.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Tu signo zodiacal es: " + signo);
        Console.WriteLine("El horóscopo: " + horoscopo);

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
