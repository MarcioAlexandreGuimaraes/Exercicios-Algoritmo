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
        
        for (int i = 0; i < N; i++)
        {
            string[] valores = Console.ReadLine().Split();
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);
            
            if (Y == 0)
                Console.WriteLine("divisao impossivel");
            else
                Console.WriteLine($"{(double)X / Y:F1}");
        }
    }
}
