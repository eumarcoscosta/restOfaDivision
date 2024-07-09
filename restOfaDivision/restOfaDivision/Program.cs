using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, i = 0, soma = 0;

            Console.WriteLine("Insira os valores abaixo: ");

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < 0 && y < 0)
            {
                Console.WriteLine("Insira um numero positivo");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

            int minX = Math.Min(x, y);
            int maxX = Math.Max(x, y);

            for (i = minX; i < maxX; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    soma = i;
                    Console.WriteLine(soma);
                }
            }
        }
    }
}
