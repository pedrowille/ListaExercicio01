using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa reajuste salarial:");
double salario = 0;
bool digitacaoInvalida=true;
while (digitacaoInvalida==true)
{
try
{
    Console.WriteLine("Informe o valor do salário:");
        salario=Convert.ToDouble(Console.ReadLine());
if (salario >0)
digitacaoInvalida=false;
else
throw new Exception();
}
catch
{
    Console.WriteLine("Salário inválido.");
}
}
double percentualAumento = 0;;
double valorAumento = 0;
double salarioReajustado = 0;
if (salario <= 2800)
{
    percentualAumento=20.0;
}
else if (salario <=7000 && salario >2800)        
        {
    percentualAumento=15.0;
}        
else if (salario <= 15000 && salario > 7000)        
{
    percentualAumento=10.0;
}
else if (salario > 15000)
{
    percentualAumento=5.0;
}
valorAumento = (percentualAumento/100) * salario;
salarioReajustado=salario+valorAumento;
Console.WriteLine("Valor anterior do salário: " + salario + "\nPercentual de aumento: " + percentualAumento + "\nValor do aumento: " + valorAumento + "\nValor do salário reajustado: " + salarioReajustado);

        }

        }
    }
