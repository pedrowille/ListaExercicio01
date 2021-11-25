using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa descobre numero par:\nInforme um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O número informado é par.");
            }
            else
            {
                Console.WriteLine("O número informado é ímpar.");
            }
        }
    }
}