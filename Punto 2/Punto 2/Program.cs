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
            int vidas = 5;
            string ramdomWord = listWord[ramdom.Next(listWord.Length)];
            int pos = ramdomWord.Length;
            Console.WriteLine("La palabra elejida tiene: " + pos + "posiciones");
            Console.WriteLine("Tiene: " + vidas + "vidas");
            Console.WriteLine("Ingrese una letra: ");
            char respuesta = Convert.ToChar(Console.ReadLine()); 
            int adivinado = validarPalabraAleatoria(ramdomWord, respuesta);
        }



        static int validarPalabraAleatoria(string ramdomWord, char attempt)
        {
            int cont = 0;
            foreach (char c in ramdomWord) {
                if (c == attempt)
                {
                    cont = cont + 1;
                }
            }
            return cont;
        }
    }
}
