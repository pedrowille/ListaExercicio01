using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa mostra numeros:\nInforme o primeiro número:");
string? textoNum1=Console.ReadLine();
int n1=Convert.ToInt32(textoNum1);
Console.WriteLine("Informe o segundo número:");
string? textoNum2=Console.ReadLine();
int n2=Convert.ToInt32(textoNum2);
        Console.WriteLine("Informe o terceiro e último número:");
        string? textoNum3=Console.ReadLine();
        int n3=Convert.ToInt32(textoNum3);
            Console.WriteLine("Exibindo o maior número:");
        if (n1 >n2 && n1>n3)
        {
            Console.WriteLine(n1);
        }
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine(n2);
}
else
    {
        Console.WriteLine(n3);
    }
    Console.WriteLine("Exibindo menor número:");
    if (n1 < n2 && n1 < n3)
    {
        Console.WriteLine(n1);
    }
else if (n2 < n1 && n2 < n3)    
{
    Console.WriteLine(n2);
}
else   
 {
     Console.WriteLine(n3);
 }
 }

}
}