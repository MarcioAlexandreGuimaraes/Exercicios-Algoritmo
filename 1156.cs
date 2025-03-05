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
        double S = 0;

        for (int i = 1; i <= 20; i++)
        {
            int numerador = 2 * i - 1;
            int denominador = (int)Math.Pow(2, i - 1);

            S += (double)numerador / denominador;
        }

        Console.WriteLine($"{S:F2}");
    }
}

