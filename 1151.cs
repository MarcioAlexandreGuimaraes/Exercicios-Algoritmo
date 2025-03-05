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
        
        int a = 0, b = 1;
        
        for (int i = 0; i < N; i++)
        {
            Console.Write(a);
            if (i < N - 1)
                Console.Write(" ");
            
            int temp = a;
            a = b;
            b = temp + b;
        }
        
        Console.WriteLine();
    }
}

