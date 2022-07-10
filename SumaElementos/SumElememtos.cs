using System;
namespace Program
{
    class SumElementos
    {
        int[] cantNum = new int[1001];
        int num, suma;

        public static void Main(string[] args)
        {
            SumElementos n = new SumElementos();

            Console.WriteLine("Ingrese la cantidad de elementos que desea  sumar: ");
            n.num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n.num + 1; i++)
            {
                Console.WriteLine("Ingrese el numero de la posicion #" + i + " que se sumara.");
                n.cantNum[i] = Convert.ToInt32(Console.ReadLine());

                n.suma = n.suma + n.cantNum[i];
            }
            Console.WriteLine("La suma de los elementos es: " + n.suma);
        }
    }
}