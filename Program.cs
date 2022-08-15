using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O valor final é " + resultado);
            Console.WriteLine($"O valor final é {resultado}"); // outro modo de concatenação.
            Console.WriteLine($"O valor final é {v1 + v2}"); // outro modo de concatenação.
            Console.WriteLine("O valor final é " + (v1 + v2)); // outro modo de concatenação.

        }
    }

}
