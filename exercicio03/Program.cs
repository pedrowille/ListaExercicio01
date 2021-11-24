using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa compra produto mais barato:\nInforme o preço do primeiro produto:");
string? tp1=Console.ReadLine();
double p1=Convert.ToDouble(tp1);
Console.WriteLine("Informe o preço do segundo produto:");
string? tp2=Console.ReadLine();
double p2=Convert.ToDouble(tp2);
Console.WriteLine("Informe o preço do terceiro produto:");
string? tp3=Console.ReadLine();
double p3=Convert.ToDouble(tp3);
if (p1 < p2 && p1 < p3)
{
    Console.WriteLine("Optando pela compra do primeiro produto, que custa" + p1);
}
else if (p2 < p1 && p2 < p3)
        {
            Console.WriteLine("Optando pela compra do segundo produto, que custa: " + p2);
        }
else
        {
            Console.WriteLine("Optando pela compra do terceiro produto, que custa: " + p3);
        }
        }
        }
        }