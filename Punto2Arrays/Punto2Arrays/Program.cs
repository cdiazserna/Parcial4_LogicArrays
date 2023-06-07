using System;

namespace Punto2Arrays
{
    public class Punto2Arrays
    {
        static string[] listWords = { "Perro", "Gato", "Cocodrilo", "Guepardo", "Gorilla", "Delfin", "Murcielago", "Mapache", "Escarabajo", "Jirafa" };
        static char[] palabraAleatoria;
        static int cartuchosRestantes;
        static void Main(string[] args)
        {
            bool jugarDeNuevo = true;

            while (jugarDeNuevo)
            {
                SeleccionarPalabraAleatoria();
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
                Console.WriteLine("Palabra: " + (letrasDescubiertas));
                Console.WriteLine("Te quedan " + cartuchosRestantes + " cartuchos para adivinar la palabra.");
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


    }
}
