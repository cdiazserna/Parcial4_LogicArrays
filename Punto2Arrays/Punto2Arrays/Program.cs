﻿using System;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listWords = { "rojo", "verde", "amarillo", "azul", "violeta", "naranja", "marron", "negro", "lila", "rosado" };
            Random random = new Random();
            string randomWord = listWords[random.Next(listWords.Length)];
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



                static char[] InitgessedLetters(int longitud)
                {
                    char[] gessedLetters = new char[longitud];
                    for (int i = 0; i < gessedLetters.Length; i++)
                    {
                        gessedLetters[i] = '_';
                    }
                    return gessedLetters;
                }
              
                }
            }
        }
    
}
