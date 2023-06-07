using System;
using System.Net.Mime;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listWord = { "Superman", "Batman", "Spider-Man", "Wonder Woman", "Iron-Man", "Captain-America", "Hulk", "Thor", "BlackWidow", "Wolverin" };
            Random ramdom = new Random();

            string ramdomWord = listWord[ramdom.Next(listWord.Length)];
        }



        static int validarPalabraAleatoria(string ramdomWord, char attempt)
        {
            int cont = 0;
            foreach (char c in ramdomWord) {
                if (c == attempt)
                {
                    cont = cont + 1;
                }


            return cont;
            }
        }
    }
}
