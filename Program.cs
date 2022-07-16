using System;

namespace T05Ejercicio20
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Qué tamañao tendrán los array?: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] arrayA = new int[longitud];
            ValoresRandom(arrayA);
            int[] arrayB = new int[longitud];
            Array.Copy(arrayA, arrayB, arrayA.Length);
            ValoresRandom(arrayA);
            int[] arrayC = new int[longitud];
            Multiplicador(arrayA, arrayB, arrayC);
            Muestra(arrayA, arrayB, arrayC);
        }

        static void Muestra(int[] arrayA, int[] arrayB, int[] arrayC)
        {
            Console.WriteLine();
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine("{0}º valor del array A: {1}", i + 1, arrayA[i]);
                Console.WriteLine("{0}º valor del array B: {1}", i + 1, arrayB[i]);
                Console.WriteLine("{0}º valor del array C (A*B): {1}", i + 1, arrayC[i]);
            }
        }

        static void Multiplicador(int[] arrayA, int[] arrayB, int[] arrayC)
        {
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayC[i] = arrayA[i] * arrayB[i];
            }
        }

        static void ValoresRandom(int[] arrayA)
        {
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = GenerarRandom();
            }
        }

        private static int GenerarRandom()
        {
            Random rnd = new Random();
            //Opto para que los números random vayan de 0 a 1000
            int aleatorio = rnd.Next(0, 1000);
            return aleatorio;
        }
    }
}