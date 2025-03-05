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
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int soma = 0;

        if (A > B)
        {
            int temp = A;
            A = B;
            B = temp;
        }

        for (int i = A + 1; i < B; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}