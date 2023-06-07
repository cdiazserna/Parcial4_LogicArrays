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

                char[] incognita = InicializarIncognita(randomWord.Length);
                int intentos = 5;

                Console.WriteLine("¡El Juego del Ahorcado!");
                Console.WriteLine("Adivine la palabra:");
                PrintIncognita(incognita);

                while (intentos > 0 && !IsAdivinarLetra(incognita))
                {
                    Console.WriteLine("\nIngrese una letra: ");
                    string input = Console.ReadLine();

                    if (input.Length == 1)
                    {
                        char Letra = input[0];

                        bool isCorrecto = ActualizarIncognita(Letra, randomWord, incognita);

                        if (isCorrecto)
                        {
                            Console.WriteLine("\n¡Correcto!");
                        }
                        else
                        {
                            intentos--;
                            Console.WriteLine("\nIncorrecto. Te quedan {0} intentos para adivinar la palabra.", intentos);
                        }

                        PrintIncognita(incognita);
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar una única letra. Intente de nuevo.");
                    }
                }

                if (IsAdivinarLetra(incognita))
                {
                    Console.WriteLine("\n¡Ha ganado!");
                }
                else
                {
                    Console.WriteLine("\nHa perdido. La palabra era: '{0}'.", randomWord);
                }

                Console.WriteLine("\n¿Quiere jugar de nuevo? (si/no)");
            } while (Console.ReadLine().ToLower() == "si");

            Console.WriteLine("\nPresione cualquier tecla para salir...");

        }

        static char[] InicializarIncognita(int length)
        {
            char[] incognita = new char[length];

            for (int i = 0; i < length; i++)
            {
                incognita[i] = '_';
            }

            return incognita;
        }

        static void PrintIncognita(char[] incognita)
        {
            Console.WriteLine();

            foreach (char c in incognita)
            {
                Console.Write(c + " ");
            }
        }

        static bool ActualizarIncognita(char NuevaLetra, string randomWord, char[] incognita)
        {
            bool isLetraCorrecta = false;

            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] == NuevaLetra)
                {
                    incognita[i] = NuevaLetra;
                    isLetraCorrecta = true;
                }
            }

            return isLetraCorrecta;
        }

        static bool IsAdivinarLetra(char[] incognita)
        {
            foreach (char c in incognita)
            {
                if (c == '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}


  

