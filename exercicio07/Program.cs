using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa calcula média:\nInforme a primeira nota:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double media = (n1 + n2) / 2;
            string conceito = "";
            bool aprovado = false;

            if (media >= 9.0 && media <= 10.0)
            {
                conceito = "a";
                aprovado = true;
            }
            else if (media > 7.5 && media < 9.0)
            {
                conceito = "b";
                aprovado = true;
            }
            else if (media >= 6.0 && media < 7.5)
            {
                conceito = "c";
                aprovado = true;
            }
            else if (media >= 4.0 && media < 6.0)
            {
                conceito = "d";
                aprovado = false;
            }
            else if (media >= 0 && media < 4.0)
            {
                conceito = "e";
                aprovado = false;
            }

            Console.WriteLine($"Média das notas {n1} e {n2}: {media}.\nConceito final: {conceito} Aprovação: {aprovado}");
        }
    }
}