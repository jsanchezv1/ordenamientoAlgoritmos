using System;

namespace Iser_directa
{
    using System;
    using System.Linq;
 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa los numeros a ordenar separados por comas(,) y presiona Enter.");
            int[] numero = Console.ReadLine().Replace(" ","").Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine();
            Console.WriteLine("ordenado:");
            Console.WriteLine(string.Join(",", Ordenar(numero)));
            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir.");
            Console.ReadKey();
        }
        private static int[] Ordenar(int[] numero)
        {
            int auxiliar;
 
            for (int p = 1; p < numero.Length; p++)
            {
                auxiliar = numero[p];
 
                for (int k = p - 1; k >= 0 && numero[k] > auxiliar; k--)
                {
                    numero[k + 1] = numero[k];
                    numero[k] = auxiliar;
                }
            }
 
            return numero;
        }
    }
}