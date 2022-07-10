using System;

namespace Program
{
    class BuscaPalabra
    {
        public static void BPalabra(string texto, string palabra)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                int l = i;
                int encontrada = 0;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (texto.Substring(l, l) == palabra.Substring(j, j))
                    {
                        encontrada++;
                    }
                    l++;
                }
                if (encontrada == palabra.Length)
                {
                    Console.WriteLine("Palabra encontrada");
                }
                else
                    Console.WriteLine("Palabra no encontrada");
            };

            static void Main(string[] args)
            {
                string s;
                string pal1 = "Hola";
                Console.WriteLine("Ingrese el texto que desea analizar que contenga la palabra (Hola)");
                s = Console.ReadLine();
                BPalabra(s, pal1);
            }
        }
    }
}
