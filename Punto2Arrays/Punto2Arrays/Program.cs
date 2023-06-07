using System;

namespace Punto2Arrays
{
    public class Punto2Arrays
    {
        static void Main(string[] args)
        {
            string[] listWords = { "Perro", "Gato", "Cocodrilo", "Guepardo", "Gorilla", "Delfin", "Murcielago", "Mapache", "Escarabajo", "Jirafa" };
            Random random = new Random();

            string randomWord = listWords[random.Next(listWords.Length)];

        }
    }
}
