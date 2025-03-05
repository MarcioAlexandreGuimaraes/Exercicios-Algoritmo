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
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                if (value % 2 == 0)
                {
                    Console.Write("EVEN (par)");
                }
                else
                {
                    Console.Write("ODD (impar) ");
                }

                if (value > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else
                {
                    Console.WriteLine("NEGATIVE");
                }
            }
        }
    }
}

