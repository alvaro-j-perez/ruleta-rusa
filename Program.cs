using System;

namespace ruleta_rusa
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Ruleta de la fortuna");
            Console.WriteLine("Tienes 5 premios sorpresa que espera para jugar?");
            int saldo = 1000;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Tu saldo es de " + saldo + " Quetzales");
                if (saldo == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No tienes dinero, gracias por jugar.");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Introduce cuanto quieres apostar, -1 para salir:");
                Console.WriteLine();
                int apuesta = int.Parse(Console.ReadLine());
                if (apuesta == -1)
                {
                    break;
                }
                if (apuesta > saldo)
                {
                    Console.WriteLine("No tienes dinero");
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine("Introduce el numero por el que quieres apostar:");
                Console.WriteLine();
                int numeroApostado = int.Parse(Console.ReadLine());
                Random Generar = new Random();
                int aleatorio = Generar.Next(0, 37);
                if (numeroApostado == aleatorio)
                {
                    Console.WriteLine();
                    Console.WriteLine("¡Enhorabuena, ha caído tu número!");
                    saldo = +apuesta * 36;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Lo siento a caido el número ");
                    saldo -= apuesta;
                   // +aleatorio;
                }
            }
            Console.ReadKey();


        }
    }
}
