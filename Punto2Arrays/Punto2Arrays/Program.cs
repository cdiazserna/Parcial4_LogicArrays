using System;

namespace Punto2Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string[] listWords = { "papas", "hijos", "hermanos", "tios", "sobrinos", "primos", "abuelos", "nietos" };
                Random random = new Random();
                string randomWord = listWords[random.Next(listWords.Length)];

                char[] incognita = InitializeIncognita(randomWord.Length);
                int intentos = 5;

                Console.WriteLine("¡El Juego del Ahorcado!");
                Console.WriteLine("Intente adivinar la palabra:");
                PrintIncognita(incognita);

                while (intentos > 0 && !IsWordGuessed(incognita))
                {
                    Console.WriteLine("\nIngresa una letra: ");
                    string input = Console.ReadLine();

                    if (input.Length == 1)
                    {
                        char guessedLetter = input[0];

                        bool isLetterInWord = UpdateIncognita(guessedLetter, randomWord, incognita);

                        if (isLetterInWord)
                        {
                            Console.WriteLine("\n¡Correcto! La letra está en la palabra.");
                        }
                        else
                        {
                            intentos--;
                            Console.WriteLine("\nIncorrecto. Te quedan {0} cartuchos para adivinar la palabra.", intentos);
                        }

                        PrintIncognita(incognita);
                    }
                    else
                    {
                        Console.WriteLine("\nDebes ingresar una única letra. Intenta de nuevo.");
                    }
                }

                if (IsWordGuessed(incognita))
                {
                    Console.WriteLine("\n¡Has ganado!");
                }
                else
                {
                    Console.WriteLine("\nHas perdido. La palabra era: '{0}'.", randomWord);
                }

                Console.WriteLine("\n¿Quieres jugar de nuevo? (s/n)");
            } while (Console.ReadLine().ToLower() == "s");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");

        }
    }
        
    }

