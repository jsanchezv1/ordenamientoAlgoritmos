using System;

namespace Bubble
{
    class Program
    {
        static int[] numbers = new int[] { 10, 2, 3, 6, 9, 1, 4, 5, 7, 8 };
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");
            Show();

            for (int k=0; k<numbers.Length; k++)
            {
                for (int p=0; p<numbers.Length-1; p++)
                {
                    if(numbers[p] > numbers[p + 1])
                    {
                        int aux = numbers[p];
                        numbers[p] = numbers[p + 1];
                        numbers[p + 1] = aux;
                    }
                }
                Show();
            }
            Show();
        }

        public static void Show()
        {
            foreach (var number in numbers)
            {
                Console.Write(number + ",");
            }
            Console.WriteLine("\n");
        }
    }
}