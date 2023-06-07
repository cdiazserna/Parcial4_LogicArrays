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

            int attempts = 5;
            bool guessed = false;

            while (attempts > 0 & guessed)

            {
                Console.WriteLine();
                Console.WriteLine("Palabra: " + new string(hiddenWord));

                char letter = GuessWord();
                bool letterfound = false;

                for (int i = 0; i < randomWord.Length; i++)
                {
                
                    if (randomWord[i] == letter) 
                    {
                        hiddenWord[i] = letter;
                        letterfound = true;
                    }
                }

                if (letterfound)
                {
                    if (new string(hiddenWord) == randomWord)

                        guessed = true;                
                }

                else
                { 
                 
                    attempts--;
                    Console.WriteLine("Te quedan" + attempts + "intentos");

                }
            }
        }

        static char GuessWord()
        {
            Console.WriteLine("Ingresa una letra");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return letter;
        }

        static void ShowResult()
        {

        }
    }
}
