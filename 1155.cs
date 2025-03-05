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

        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i;
        }

       
        Console.WriteLine($"{S:F2}");
    }
}

