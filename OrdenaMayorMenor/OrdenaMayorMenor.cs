using System;
namespace Program
{
    class OrdenMenorMayor
    {
        int[] Vlista = new int[1001];
        int tam, temp;

        public static void Main(string[] args)
        {
            OrdenMenorMayor m = new OrdenMenorMayor();

            Console.WriteLine("Ingrese la cantidad de elementos que desea  ordenar: ");
            m.tam = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < m.tam + 1; i++)
            {
                Console.WriteLine("Ingrese el digito #" + i);
                m.Vlista[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 2; i < m.tam + 1; i++)
            {
                for (int j = 1; j < m.tam - i + 2; j++)
                {
                    if (m.Vlista[j] < m.Vlista[j + 1])
                    {
                        m.temp = m.Vlista[j];
                        m.Vlista[j] = m.Vlista[j + 1];
                        m.Vlista[j + 1] = m.temp;
                    }

                }
            }
            Console.WriteLine("Lista ordenada: ");
            for (int i = 1; i < m.tam + 1; i++)
            {
                Console.WriteLine("[" + i + "] :" + m.Vlista[i]);
            }
        }
    }
}
