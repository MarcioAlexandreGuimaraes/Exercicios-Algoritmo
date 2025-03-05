/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int totalCobaias = 0, coelhos = 0, ratos = 0, sapos = 0;

        for (int i = 0; i < N; i++)
        {
            string[] dados = Console.ReadLine().Split();
            int quantia = int.Parse(dados[0]);
            char tipo = char.Parse(dados[1]);

            totalCobaias += quantia;

            if (tipo == 'C') coelhos += quantia;
            if (tipo == 'R') ratos += quantia;
            if (tipo == 'S') sapos += quantia;
        }

        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {(coelhos * 100.0) / totalCobaias:F2} %");
        Console.WriteLine($"Percentual de ratos: {(ratos * 100.0) / totalCobaias:F2} %");
        Console.WriteLine($"Percentual de sapos: {(sapos * 100.0) / totalCobaias:F2} %");
    }
}
