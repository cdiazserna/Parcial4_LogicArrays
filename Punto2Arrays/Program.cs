using System;
using System.ComponentModel.Design;

namespace Punto2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listWords =
            {
                "tvs", "bmw", "bajaj", "honda", "suzuki", "akt", "hero", "yamaha", "royalenfield", "kawasaki"
            };

            Random random= new Random();

            string randomWord = listWords[random.Next(listWords.Length)];

            int menu = 1;
            int intentomaximo = 5;
            int intentorealizado = 0;
            bool juegoTerminado = false;

            string[] randomletter = new string[randomWord.Length];
            for (int i = 0; i < randomWord.Length; i++)
            {
                randomletter[i] = randomWord[i].ToString();
            }

            string[] palabradivinada = new string[randomWord.Length];
            for (int i = 0; i < palabradivinada.Length; i++)
            {
                palabradivinada[i] = "_";
            }

            while (menu ==1)
            {
                Console.WriteLine("Juego del ahorcadito");
                while (!juegoTerminado)
                {
                    Console.WriteLine("\nPalabra: " + String.Join(" ", palabradivinada));
                    Console.WriteLine("Intentos restantes: " + (intentomaximo - intentorealizado));

                    Console.Write("Ingresa una letra: ");
                    string letra = Console.ReadLine().ToLower();

                    bool letradivinada = false;
                    for (int i = 0; i < randomletter.Length; i++)
                    {
                        if (randomletter[i] == letra)
                        {
                            palabradivinada[i] = letra;
                            letradivinada = true;
                        }
                    }

                    if (!letradivinada)
                    {
                        intentorealizado++;
                        Console.WriteLine("¡Letra incorrecta!");
                    }

                    if (intentorealizado >= intentomaximo)
                    {
                        juegoTerminado = true;
                        Console.WriteLine("\n Perdiste :C La palabra era: " + randomWord);
                        Console.WriteLine(" Moriste ahorcado vilmente!!!");
                    }
                    else if (String.Join("", palabradivinada) == randomWord)
                    {
                        juegoTerminado = true;
                        Console.WriteLine("\n ADIVINASTE LA PALABRA :D");
                    }
                }

                Console.WriteLine("Presiona 1 para volver al menú o 0 para salir de la calculadora");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }                      
        }
    }
}
