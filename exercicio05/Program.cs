using System;

namespace Exercicio05
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa cálculo folha de pagamento:\nInforme o valor da sua hora:");
int valorHora=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a quantidade de horas trabalhadas no mês:");
int qtdHoras=Convert.ToInt32(Console.ReadLine());
double salarioBruto=qtdHoras * valorHora;
double salarioLiquido,totalDescontos;
double descontoIr;
double descontoINSS=10.0;
double valorDescontoINSS=(descontoINSS/100) * salarioBruto;
double percentualFGTS=11.0;
double valorFGTS=(percentualFGTS/100) * salarioBruto;;
if (salarioBruto <=2000)
{
    descontoIr=0;
}
else if (salarioBruto <=5000)
        {
            descontoIr=5.0;        
        }
else if (salarioBruto <=7500)
        {
            descontoIr=10.0;
        }
        else
        {
            descontoIr=20.0;
        }
        double valorDescontoIr=(descontoIr/100) * salarioBruto;
        totalDescontos= valorDescontoIr + valorDescontoINSS;
        Console.WriteLine("Salário bruto: " + salarioBruto);
        Console.WriteLine("Desconto IR: " + descontoIr + "%, r$" + valorDescontoIr);
        Console.WriteLine("Desconto INSS: " + descontoINSS + "%, r$" + valorDescontoINSS);
Console.WriteLine("Fgts: " + percentualFGTS + "%, r$" + valorFGTS);
Console.WriteLine("Total de descontos: r$" + totalDescontos);
        salarioLiquido=salarioBruto - totalDescontos;
        Console.WriteLine("Salário líquido: r$" + salarioLiquido);
        }
    }
}