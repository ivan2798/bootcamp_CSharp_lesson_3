using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

// Hello World! program
namespace C_Sharp_bootcamp_lesson3
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad,por favor");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");

            else
            {
                Console.WriteLine("¿Tienes carnet?");

                string carnet = Console.ReadLine();

                int compara = string.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                else Console.WriteLine("Lo siento mucho no puedes conducir");

            }


        }

       
    }
}
