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
        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = i + 6; j >= i + 4; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}


