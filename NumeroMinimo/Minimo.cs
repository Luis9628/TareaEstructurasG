using System;
namespace Program
{
    class NumeroMinimo
    {
        int[] cantNum = new int[1001];
        int aux;
        public void SacarNumMinimo()
        {
           
            Console.WriteLine("Ingrese la cantidad de numeros a evaluar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num + 1; i++)
            {
                Console.WriteLine("Ingrese el numero de la posicion: " + i);
                cantNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            aux = cantNum[1];
            for (int i = 1; i < num + 1; i++)
            {
                if (cantNum[i] < aux)
                {
                    aux = cantNum[i];
                }
            }           
            Console.WriteLine("El numero maximo de los elementos es: " + aux);
        }
        public class Prueba
        {
            public static void Main(string[] args)
            {
                NumeroMinimo n = new NumeroMinimo();
                n.SacarNumMinimo();
            }
        }
    }
}
