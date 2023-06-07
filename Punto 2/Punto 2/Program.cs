using System;
using System.Net.Mime;
using System.Runtime;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool ban = false;
            string[] listWord = { "superman", "batman", "aquaman", "deadpool", "flash", "daredevil", "hulk", "thor", "blackWidow", "wolverin" };
            Random ramdom = new Random();
            int vidas = 5;
            //string ramdomWord = listWord[ramdom.Next(listWord.Length)];
            string ramdomWord = "aabala";
            char[] palabraSecreta = new char[ramdomWord.Length];
            foreach (char c in  ramdomWord)
            {
                palabraSecreta[i] = c;
                i++;
            }
            int pos = ramdomWord.Length;
            int aciertos = 0;
            while (vidas >= 0) {
                
                Console.WriteLine("La palabra tiene: " + pos + " posiciones");
                Console.WriteLine("Tiene: " + vidas + " vidas");
                Console.WriteLine("Ingrese una letra: ");
                char respuesta = Convert.ToChar(Console.ReadLine());
                int adivinado = validarPalabraAleatoria(ramdomWord, respuesta,palabraSecreta);

                if (adivinado == 0)
                {
                    Console.WriteLine("No ha acertado\n");
                    vidas = vidas - 1;
                }
                else
                {
                    Console.WriteLine("Ha acertado\n");
                    aciertos++;
                    pos = pos - adivinado;

                    if (pos == 0)
                    {

                        ban = true;
                        break;
                        
                    }
                }

                

            }
            if (ban)
            {
                Console.WriteLine("array: " + palabraSecreta);
            }

            else
            {
                Console.WriteLine("Ha perdido la palabra era: " + ramdomWord);
                Console.WriteLine("array: " + palabraSecreta);
            }

        }



        static int validarPalabraAleatoria(string ramdomWord, char attempt, char[] list)
        {
            int cont = 0;
            foreach (char c in ramdomWord) {
                if (c == attempt)
                {
                    cont = cont + 1;
                    eliminar(list, c);
                }
            }
            return cont;
        }


        static void eliminar(char[] list, char attempt)
        {
            int j = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != attempt)
                {
                    list[j] = list[i];
                    j++;
                }
            }

            // Rellenar el resto del array con espacios en blanco
            for (int i = j; i < list.Length; i++)
            {
                list[i] = ' ';
            }
        }
    }
}
