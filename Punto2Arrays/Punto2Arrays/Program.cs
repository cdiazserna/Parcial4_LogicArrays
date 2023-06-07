using System;
using System.Net;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Ahorcadito");
            Console.WriteLine(" Basado en Marca de Relojes");
            string[]listword = { "rolex", "yess", "cassio", "ap", "hublot", "tagheuer" };
            Random random= new Random();
            string randomword = listword[random.Next(listword.Length)];
            char[]letters=new char[randomword.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = randomword[i];
                Console.WriteLine(letters[i]);
            }

        }
    }
}
