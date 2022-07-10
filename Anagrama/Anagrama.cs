using System;

namespace Program
{
    class Anagrama
    {
        static void IAnagrama(string p1,string p2)
        {
            bool anagrama;
            Console.Clear();
            
        if(p1.Length != p2.Length)
            {
                anagrama = false;
            }
            else
            {
                char[] l1 = p1.ToCharArray();
                Array.Sort(l1);
                char[] l2 = p2.ToCharArray();
                Array.Sort(l2);
                string pa1 = new string(l1);
                string pa2 = new string(l2);
                if(pa1 == pa2)
                {
                    anagrama = true;
                }
                else
                {
                    anagrama = false;
                }
                if(anagrama == true)
                {
                    Console.WriteLine("Las palabras {0} y {1} son anagramas", p1, p2);
                }
                else
                {
                    Console.WriteLine("Las palabras {0} y {1} NO son anagramas", p1, p2);
                }
            }

        }
        static void Main(string[] args)
        {
            string? p1, p2;
            Console.WriteLine("Ingrese la primer palabra: ");
            p1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese la segunda palabra: ");
            p2 = Console.ReadLine().ToLower();
            IAnagrama(p1, p2);
            Console.ReadKey();
        }
    }
}