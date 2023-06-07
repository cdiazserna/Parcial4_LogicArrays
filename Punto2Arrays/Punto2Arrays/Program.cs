using System;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listWords = { "rojo", "verde", "amarillo", "azul", "violeta", "naranja", "marron", "negro", "lila", "rosado" };
            Random random = new Random();
            char[] randomWord = listWords[random.Next(listWords.Length)];
            // almacenamos la paralbra en uun array
            char[] gessedLetters = InitgessedLetters(randomWord.Length);//tenemos que definir un metodo para inicializar 

            // utilizamos while como condicional
            int triesRemaining = 5;

            while (triesRemaining > 0)
            {
                Console.WriteLine("Gess the word:");
                Console.WriteLine(gessedLetters);//usaremos el metodo gessedLetters

                Console.WriteLine("Enter a letter:");
                char letter = char.ToLower(Console.ReadKey().KeyChar);

                bool letterFound = updtgessedLetters(letter,randomWord, gessedLetters);
                if (letterFound)
                {
                    if (areEqual(gessedLetters, randomWord))
                    {
                        Console.WriteLine("\n¡winner!");
                        return;
                    }
                }
                else
                {
                    triesRemaining--;
                    Console.WriteLine($"\n you have {triesRemaining} tries to guess the word.");
                }

            }
            Console.WriteLine($"\nYou lose the word is '{randomWord}'.");
        }


        //static string selectrandomWord(string[] words)
        //        {
        //            Random random = new Random();
        //            int indiceAleatorio = random.Next(words.Length);
        //            return words[RandomIndex];
        //            }

        static char[] getLettersword(string word)
        {
            return word.ToCharArray();
        }

        static char[] InitgessedLetters(int length)
        {
            char[] gessedLetters = new char[length];
            for (int i = 0; i < gessedLetters.Length; i++)
            {
                gessedLetters[i] = '_';
            }
            return gessedLetters;
        }
        static bool updtgessedLetters(char letter, char[] lettersWord, char[] lettersGessed)
        {
            bool letterFound = false;
            for (int i = 0; i < lettersWord.Length; i++)
            {
                if (lettersWord[i] == letter)
                {
                    lettersGessed[i] = letter;
                    letterFound = true;
                }
            }
            return letterFound;
        }
        static bool areEqual(char[] array1, char[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;

        }
    }
}
            
        
    

