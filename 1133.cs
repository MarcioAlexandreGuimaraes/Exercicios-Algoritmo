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
        string[] valores = Console.ReadLine().Split();
        int X = int.Parse(valores[0]);
        int Y = int.Parse(valores[1]);

        int inicio = Math.Min(X, Y);
        int fim = Math.Max(X, Y);

        for (int i = inicio; i <= fim; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
