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
        int n = int.Parse(Console.ReadLine());
        int dentro = 0;
        int fora = 0;

        for (int i = 0; i < n; i++)
        {
            int A = int.Parse(Console.ReadLine());

            if (A >= 10 && A <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }

        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");
    }
}
