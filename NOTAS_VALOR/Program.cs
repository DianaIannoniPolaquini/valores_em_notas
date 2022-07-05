using System;

namespace NOTAS_VALOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor: ");
            int x = int.Parse(Console.ReadLine()); 
            Console.WriteLine();

            int n100 = x / 100;
            int r100 = x % 100;

            int n50 = r100 / 50;
            int r50 = x % 50;

            int n20 = r50 / 20;
            int r20 = r50 % 20;

            int n10 = r20 / 10;
            int r10 = r20 % 10;

            int n5 = r10 / 5;
            int r5 = r10 % 5;

            int n2 = r5 / 2;
            int r2 = r5 % 2;

            int n1 = r2;

            Console.WriteLine(n100 + " Nota (s) de R$ 100,00.");
            Console.WriteLine(n50 + " Nota (s) de R$ 50,00.");
            Console.WriteLine(n20 + " Nota (s) de R$ 20,00.");
            Console.WriteLine(n10 + " Nota (s) de R$ 10,00.");
            Console.WriteLine(n5 + " Nota (s) de R$ 5,00.");
            Console.WriteLine(n2 + " Nota (s) de R$ 2,00.");
            Console.WriteLine(n1 + " Nota (s) de R$ 1,00.");
        }
    }
}
