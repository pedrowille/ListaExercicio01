using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa data válida:\nInforme uma data no formato dia/mês/ano:");
            int dia = Convert.ToInt32(Console.ReadLine());
            int mes = Convert.ToInt32(Console.ReadLine());
            int ano = Convert.ToInt32(Console.ReadLine());
            if (validaData(dia, mes, ano))
            {
                Console.WriteLine("A data indicada é válida.");
            }
            else
            {
                Console.WriteLine("A data é inválida.");
            }
        }
        static bool validaData(int d, int m, int a)
        {
            if (d > 0 && d <= 31 && m > 0 && m <= 12 && a > 0 && a <= 9999)
            {
                if (m == 4 && d > 30)
                {
                    return false;
                }
                else if (m == 2 && d > 28)
                {
                    return false;
                }
                else if (m == 6 && d > 30)
                {
                    return false;
                }
                else if (m == 9 && d > 30)
                {
                    return false;
                }
                else if (m == 11 && d > 30)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}