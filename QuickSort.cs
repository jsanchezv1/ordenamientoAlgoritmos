using System;

namespace Quick
{
    class Program
    {
        static void quicksort(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indiceParticion = particion(arreglo, izquierda, derecha);
                quicksort(arreglo, izquierda, indiceParticion);
                quicksort(arreglo, indiceParticion + 1, derecha);
            }
        }
        static int particion(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[izquierda];
            while (true)
            {
                while (arreglo[izquierda] < pivote)
                {
                    izquierda++;
                }

                while (arreglo[derecha] > pivote)
                {
                    derecha--;
                }

                if (izquierda >= derecha)
                {
                    return derecha;
                }
                else
                {
                    int temporal = arreglo[izquierda];
                    arreglo[izquierda] = arreglo[derecha];
                    arreglo[derecha] = temporal;
                    derecha--; izquierda++;

                }
 
            }
        }
        static void Main(string[] args)
        {

            int[] arreglo = { 10, 7, 1, 22, 2, 3, 8, 11, 5, 12 };
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento);
                Console.Write(",");
            }

            quicksort(arreglo, 0, arreglo.Length - 1);
            Console.WriteLine("\nordenado: ");
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento);
                Console.Write(",");
            }

        }

    }
}