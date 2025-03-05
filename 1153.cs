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
        long fatorial = 1;

        for (int i = 1; i <= N; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine(fatorial);
    }
}

