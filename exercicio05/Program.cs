using System;

namespace Exercicio05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa cálculo folha de pagamento:");
            double valorHora = 0;
            int qtdHoras = 0;
            while (valorHora <1 || qtdHoras <1)
        {
                try
                {
                    Console.WriteLine("Informe o valor da sua hora:");
                    valorHora = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de horas trabalhadas no mês:");
                    qtdHoras = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor(es) inválido(s).");
                }
            }
            double salarioBruto = qtdHoras * valorHora;
            double salarioLiquido, totalDescontos;
            double descontoIr;
            double descontoINSS = 10.0;
            double valorDescontoINSS = (descontoINSS / 100) * salarioBruto;
            double percentualFGTS = 11.0;
            double valorFGTS = (percentualFGTS / 100) * salarioBruto; ;
            if (salarioBruto <= 2000)
            {
                descontoIr = 0;
            }
            else if (salarioBruto <= 5000)
            {
                descontoIr = 5.0;
            }
            else if (salarioBruto <= 7500)
            {
                descontoIr = 10.0;
            }
            else
            {
                descontoIr = 20.0;
            }
            double valorDescontoIr = (descontoIr / 100) * salarioBruto;
            totalDescontos = valorDescontoIr + valorDescontoINSS;
            Console.WriteLine("Salário bruto: " + salarioBruto);
            Console.WriteLine("Desconto IR: " + descontoIr + "%, r$" + valorDescontoIr);
            Console.WriteLine("Desconto INSS: " + descontoINSS + "%, r$" + valorDescontoINSS);
            Console.WriteLine("Fgts: " + percentualFGTS + "%, r$" + valorFGTS);
            Console.WriteLine("Total de descontos: r$" + totalDescontos);
            salarioLiquido = salarioBruto - totalDescontos;
            Console.WriteLine("Salário líquido: r$" + salarioLiquido);
        }
    }
}