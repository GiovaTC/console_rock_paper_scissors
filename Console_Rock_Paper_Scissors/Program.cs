using System;

class Program
{
    static void Main()
    {
        string[] opciones = { "piedra", "papel", "tijeras" };
        Random random = new Random();

        Console.WriteLine(" ¡Bienvenido a Piedra, Papel o Tijeras! ");

        while(true)
        {
            Console.WriteLine("Elige (piedra, papel, tijeras o salir): ");
            string jugador = Console.ReadLine().ToLower();

            if (jugador == "salir")
            {
                Console.WriteLine(" ¡Gracias por jugar! Hasta la próxima.");
                break;
            }

            if (Array.IndexOf(opciones, jugador) == -1)
            {
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                continue; 
            }

            string computadora = opciones[random.Next(opciones.Length)];
            Console.WriteLine($"La computadora eligió: {computadora}");

            if (jugador == computadora)
            {
                Console.WriteLine("🤝 ¡Empate!");
            }
            else if ((jugador == "piedra" && computadora == "tijeras") ||
                     (jugador == "papel" && computadora == "piedra") ||
                     (jugador == "tijeras" && computadora == "papel"))
            {
                Console.WriteLine("🎉 ¡Ganaste!");
            }
            else
            {
                Console.WriteLine("💀 Perdiste. Inténtalo de nuevo.");
            }
        }
    }
}
