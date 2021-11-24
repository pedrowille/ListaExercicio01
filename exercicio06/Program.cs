using System;

namespace Exercicio06
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa exibe dias da semana:\nInforme o número correspondente ao dia:");
int dia=Convert.ToInt32(Console.ReadLine());
if (dia==1)
{
 Console.WriteLine("Domingo.");   
}
else if (dia==2)
{
    Console.WriteLine("Segunda-feira.");
}
else if (dia==3)
{
    Console.WriteLine("Terça-feira.");
}
        else if (dia==4)
{
    Console.WriteLine("Quarta-feira.");
}        
else if (dia==5)
        {
            Console.WriteLine("Quinta-feira.");
        }
else if (dia==6)
        {
            Console.WriteLine("Sexta-feira.");
        }
else if (dia==7)
        {
            Console.WriteLine("Sábado.");
        }
else
{
    Console.WriteLine("Valor inválido.");
}
        }
    }
}