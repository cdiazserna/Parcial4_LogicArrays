using System;

namespace Punto2Arrays
{
    public class Punto2Arrays
    {
        static string[] listWords = { "perro", "gato", "cocodrilo", "guepardo", "gorilla", "delfin", "murcielago", "mapache", "escarabajo", "jirafa" };
        static char[] palabraAleatoria;
        static int cartuchosRestantes;
        static void Main(string[] arg)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*¡Bienvenido al juego del ahorcado!*");
            Console.WriteLine("************************************");
            Console.WriteLine();

            bool jugarDeNuevo = true;
            while (jugarDeNuevo)
            {
                SeleccionarPalabraAleatoria();
                InicializarJuego();
                Jugar();
                Console.WriteLine("¿Quieres jugar de nuevo? (s/n): ");
                char opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();

                jugarDeNuevo = (opcion == 's' || opcion == 'S');

            }
        }
        static void SeleccionarPalabraAleatoria()
        {
            Random random = new Random();
            int randomWord = random.Next(0, listWords.Length);
            palabraAleatoria = listWords[randomWord].ToCharArray();

        }

        static void InicializarJuego()
        {
            cartuchosRestantes = 5;
        }

        static void Jugar()
        {
            bool[] letrasDescubiertas = new bool[palabraAleatoria.Length];

            while (cartuchosRestantes > 0 && Array.IndexOf(letrasDescubiertas, false) != -1)
            {
                Console.WriteLine("Palabra: " + ObtenerEstadoPalabra(letrasDescubiertas));
                Console.WriteLine();
                Console.WriteLine("Te quedan " + cartuchosRestantes + " cartuchos para adivinar la palabra.");
                Console.WriteLine();
                Console.Write("Ingresa una letra: ");
                char letra = Console.ReadKey().KeyChar;
                Console.WriteLine();

                bool letraEncontrada = false;

                for (int i = 0; i < palabraAleatoria.Length; i++)
                {
                    if (palabraAleatoria[i] == letra)
                    {
                        letrasDescubiertas[i] = true;
                        letraEncontrada = true;
                    }
                }

                if (letraEncontrada)
                {
                    Console.WriteLine("¡Letra encontrada!");
                }
                else
                {
                    cartuchosRestantes--;
                    Console.WriteLine("La letra no está en la palabra.");
                }

                Console.WriteLine();
            }

            if (cartuchosRestantes == 0)
            {
                Console.WriteLine("Has perdido, la palabra era '" + new string(palabraAleatoria) + "'.");
            }
            else
            {
                Console.WriteLine("¡Has ganado!");
            }
        }

        static string ObtenerEstadoPalabra(bool[] letrasDescubiertas)
        {
            string estado = "";

            for (int i = 0; i < palabraAleatoria.Length; i++)
            {
                estado += letrasDescubiertas[i] ? palabraAleatoria[i] + " " : "_ ";
            }

            return estado.Trim();
        }


    }
}
