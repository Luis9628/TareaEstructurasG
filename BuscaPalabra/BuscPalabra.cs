using System;
using System.Globalization;

namespace Program
{
    class BuscaPalabra
    {
        string p1 = "hola",p2="HOLA",p3="Hola";


        public static void Main(string[] args)
        {
            BuscaPalabra b = new BuscaPalabra();
            string? texto;

            Console.WriteLine("Ingrese el texto que desea analizar que contenga la palabra (Hola)");
            texto = Console.ReadLine();
            if (texto is not null)
            {
                if (texto.Contains(b.p1) || texto.Contains(b.p2) || texto.Contains(b.p3))
                {                 
                    Console.WriteLine("Palabra encontrada");
                }                                
                else
                    Console.WriteLine("Palabra no encontrada");
            }
        }
    }
}
