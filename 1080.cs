/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int maior = int.MinValue;
        int posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor > maior)
            {
                maior = valor;
                posicao = i;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
