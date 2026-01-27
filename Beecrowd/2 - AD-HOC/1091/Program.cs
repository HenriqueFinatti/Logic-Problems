using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Inicio:
        int casos = int.Parse(Console.ReadLine());

        if (casos != 0)
        {
            int[] divisor = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int divisorX, divisorY;

            divisorX = divisor[0];
            divisorY = divisor[1];

            for (int i = 0; i < casos; i++)
            {
                int[] casa = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int casaX, casaY;

                casaX = casa[0];
                casaY = casa[1];

                if (casaX == divisorX || casaY == divisorY)
                {
                    Console.WriteLine("divisa");
                    continue;
                }

                if (casaY > divisorY)
                {
                    if (casaX > divisorX)
                    {
                        Console.WriteLine("NE");
                        continue;
                    }
                    Console.WriteLine("NO");
                    continue;
                }

                if (casaX > divisorX)
                {
                    Console.WriteLine("SE");
                    continue;
                }
                Console.WriteLine("SO");
            }
            goto Inicio;
        }
    }
}
