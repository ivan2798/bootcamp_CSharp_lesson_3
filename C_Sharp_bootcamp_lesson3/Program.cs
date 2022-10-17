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

            Console.WriteLine("¿Tienes carnet?");

            string carnet = Console.ReadLine();

            if (edad >= 18 && carnet == "si")
            {
                Console.WriteLine("Puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }


        }

       
    }
}
