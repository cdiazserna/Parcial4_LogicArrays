using System;

namespace Punto2Arrays
{
    public class Punto2Arrays
    {
        static string[] listWords = { "Perro", "Gato", "Cocodrilo", "Guepardo", "Gorilla", "Delfin", "Murcielago", "Mapache", "Escarabajo", "Jirafa" };
        Random random = new Random();
        static char[] palabraAleatoria;
        static int cartuchosRestantes;
        static void Main(string[] args)
        {
            //string randomWord = listWords[random.Next(listWords.Length)];

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
            Random rnd = new Random();
            int indiceAleatorio = rnd.Next(0, listWords.Length);
            palabraAleatoria = listWords[indiceAleatorio].ToCharArray();
        }

        static void InicializarJuego()
        {
            cartuchosRestantes = 5;
        }


    }
}
