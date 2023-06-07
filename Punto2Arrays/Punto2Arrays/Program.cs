using System;

namespace Punto2Arrays
{
    public class Punto2Arrays
    {
        string[] listWords = { "Perro", "Gato", "Cocodrilo", "Guepardo", "Gorilla", "Delfin", "Murcielago", "Mapache", "Escarabajo", "Jirafa" };
        Random random = new Random();
        
        
        //string randomWord = listWords[random.Next(listWords.Length)];
        static void Main(string[] args)
        {
            
            bool jugarDeNuevo = true;

            while (jugarDeNuevo)
            {
               
                Console.WriteLine("¿Quieres jugar de nuevo? (s/n): ");
                char opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();

                jugarDeNuevo = (opcion == 's' || opcion == 'S');

            }
        }
}
