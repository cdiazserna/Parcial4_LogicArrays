using System;

namespace Punto2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] listWords = { "perro", "gato", "leon", "cocodrilo", "girafa", "elefante" };
            Random random = new Random();
            string randomWord = listWords[random.Next(listWords.Length)];

            Console.WriteLine("¡Bienvenido al juego del Ahorcadito!");
            Console.WriteLine("Adivina la palabra oculta");

            char[] hiddenWord = new char[randomWord.Length];
            for (int i=0; i < hiddenWord.Length; i++) 
            {
                hiddenWord[i] = '_';
            }
        }

        static void GuessWord()
        {

        }

        static void ShowResult()
        {

        }
    }
}
