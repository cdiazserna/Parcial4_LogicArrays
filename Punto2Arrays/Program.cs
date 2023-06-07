using System;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listWords =
            {
                "tvs, bmw, bajaj, honda, suzuki, akt, hero, yamaha, royalenfild, kawasaki"
            };

            Random random= new Random();

            string randomWord = listWords[random.Next(listWords.Length)];

            int intentosMaximos = 5;
            int intentosRealizados = 0;
            bool juegoTerminado = false;

            string[] letrasPalabraSecreta = new string[randomWord.Length];
            for (int i = 0; i < randomWord.Length; i++)
            {
                letrasPalabraSecreta[i] = randomWord[i].ToString();
            }

            string[] palabraAdivinada = new string[randomWord.Length];
            for (int i = 0; i < palabraAdivinada.Length; i++)
            {
                palabraAdivinada[i] = "_";
            }

            Console.WriteLine("¡Bienvenido al juego del Ahorcado!");
            while (!juegoTerminado)
            {
                Console.WriteLine("\nPalabra: " + String.Join(" ", palabraAdivinada));
                Console.WriteLine("Intentos restantes: " + (intentosMaximos - intentosRealizados));

                Console.Write("Ingresa una letra: ");
                string letra = Console.ReadLine().ToLower();

                
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
