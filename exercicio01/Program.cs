using System;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa calcula media:\nInforme a primeira nota:");
string textoNota1=Console.ReadLine();
Console.WriteLine("Digite a segunda nota:");
string textoNota2=Console.ReadLine();
double n1=Convert.ToDouble(textoNota1);
        double n2=Convert.ToDouble(textoNota2);
        double media = (n1+n2)/2;
        if (media ==10)
{
    Console.WriteLine("Aprovado com distinção!");
}        
    else if (media >= 7)
    {
        Console.WriteLine("Aprovado");
    }
else
{
  Console.WriteLine("Reprovado");  
}    }
}
}