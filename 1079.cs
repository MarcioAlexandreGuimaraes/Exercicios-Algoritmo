using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            double a = double.Parse(inputs[0]);
            double b = double.Parse(inputs[1]);
            double c = double.Parse(inputs[2]);

            double mediaPonderada = (a * 2 + b * 3 + c * 5) / 10;

            Console.WriteLine($"{mediaPonderada:F1}");
        }
    }
}


