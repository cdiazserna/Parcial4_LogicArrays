using System;
using System.Net.Mime;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] listWord = { "superman", "batman", "aquaman", "deadpool", "flash", "daredevil", "hulk", "thor", "blackWidow", "wolverin" };
            Random ramdom = new Random();
            int vidas = 5;
            string ramdomWord = listWord[ramdom.Next(listWord.Length)];
            char[] palabraSecreta = new char[ramdomWord.Length];
            foreach (char c in  ramdomWord)
            {
                palabraSecreta[i] = c;
                i++;
            }
            int pos = ramdomWord.Length;

            while (vidas >= 0) {

                Console.WriteLine("La palabra tiene: " + pos + "posiciones");
                Console.WriteLine("Tiene: " + vidas + "vidas");
                Console.WriteLine("Ingrese una letra: ");
                char respuesta = Convert.ToChar(Console.ReadLine());
                int adivinado = validarPalabraAleatoria(ramdomWord, respuesta);

                if (adivinado == 0)
                {
                    Console.WriteLine("No ha acertado");
                    vidas = vidas - 1;
                }

            }

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


        static void eliminar(int[] list)
        {

            foreach( char c in list)
            {

            }
        }
    }
}
