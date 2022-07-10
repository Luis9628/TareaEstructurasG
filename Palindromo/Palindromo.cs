using System;


namespace Program
{
    class Palindromo
    {
        static void Main(string[] args)
        {
            string? palabra, inverso, caracter;
            int a;
            Console.WriteLine("Ingrese la palabra que desea identificar si es Palindromo o no: ");
            palabra = Convert.ToString(Console.ReadLine());
            a = palabra.Length;
            inverso = "";
            for(int i = a - 1; i >= 0; i--)
            {
                caracter = palabra.Substring(i, 1);
                inverso = inverso + caracter;
            }
            if (palabra == inverso)
            {
                Console.WriteLine(palabra + " Es un palindromo");
            }
            else
            {
                Console.WriteLine(palabra + " No es un palindromo");
            }
            Console.ReadKey();
        }
    }
}
//El sistema cuenta con una falla ya que no identifica o cambia las minusculas o mayusculas de las palabras.