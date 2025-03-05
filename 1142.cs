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

        int inicio = 1;
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{inicio} {inicio + 1} {inicio + 2} PUM");
            inicio += 4;
        }
    }
}
