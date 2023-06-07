using System;

namespace Punto2Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
                
                    string[] listWords = { "papas", "hijos", "hermanos", "tios", "sobrinos", "primos", "abuelos", "nietos" };
                    Random random = new Random();
                    string randomWord = listWords[random.Next(listWords.Length)];
             
         }
        
    }
}
