using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa calcula lados de um triângulo:\nInforme o lado A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado C:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c || a + c > b || b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isósceles.");
                }
                else if (a != b && a != c && b != c)
                {
                    Console.WriteLine("Triângulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é triângulo.");
            }
        }
    }
}