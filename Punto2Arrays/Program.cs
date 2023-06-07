using System;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listWords =
            {
                "tvs, bmw, bajaj, honda, suzuki, akt, hero, victory, yamaha, royalenfild, kawasaki"
            };
            Random random= new Random();

            string randomWord = listWords[random.Next(listWords.Length)];
            
        }
    }
}
