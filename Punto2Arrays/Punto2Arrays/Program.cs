using System;
using System.Net;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts = 5,sthw=1,swth=1;
            char letter;
            string rest;
            while (swth == 1)
            {
                Console.WriteLine("  ****************  Bienvenidos al Ahorcadito   **********************\n");
                Console.WriteLine(" \nBasado en Marca de Relojes\n");
                string[] listword = { "rolex", "yess", "cassio", "ap", "hublot", "tagheuer" };
                Random random = new Random();
                string randomword = listword[random.Next(listword.Length)];
                char[] letters = new char[randomword.Length];
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = randomword[i];

                }
                Console.WriteLine("\ntines 5 intentos antes de ser ahorcado\n");

                while (sthw == 1)
                {
                    Console.WriteLine("digita una letra");
                    letter = Convert.ToChar(Console.ReadLine());
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (letter == letters[i])
                        {
                            Console.WriteLine(string.Format("la letra : {0} , es parte de la palabra en la posicion {1}", letter, i));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("la letra : {0} ,no es parte de la palabra en la posicion {1}", letter, i));

                        }

                    }
                    KnowWhat(out rest, randomword, out sthw, attempts);
                }
                Console.WriteLine(" si deseas jugar otra vez marca 1 o cualquiera para salir");
                swth=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            
        }
        public static void KnowWhat(out string rest,string randomword,out int sthw, int attempts)
        {
            sthw = 1;
            Console.WriteLine("si sabe cual es digita");
            rest = Console.ReadLine();
            if (rest == randomword)
            {
                Console.WriteLine(" has ganado ");
                sthw = 0;
            }
            else Console.WriteLine(" no era, sigue intentando");

            attempts--;
            if (attempts == 0)
            {
                sthw = 0;
                Console.WriteLine(" haz perdido");
            }
        }
    }
}
