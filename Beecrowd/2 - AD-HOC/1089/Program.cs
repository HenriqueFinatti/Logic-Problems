using System;
using System.Linq;
class Program
{
    static bool verificaPico(int ondaAtual, int ondaAnterior, int ondaSeguinte)
    {
        if (ondaAtual < ondaSeguinte && ondaAtual < ondaAnterior)
        {
            return true;
        }

        if (ondaAtual > ondaSeguinte && ondaAtual > ondaAnterior)
        {
            return true;
        }

        return false;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            int size = int.Parse(Console.ReadLine());
            int picos = 0;
            if (size == 0) break;

            int[] ondas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ondaAtual = ondas[0];
            int ondaAnterior = ondas[ondas.Length-1];
            int ondaSeguinte = ondas[1];

            if (verificaPico(ondaAtual, ondaAnterior, ondaSeguinte))
            {
                picos++;
            }
            for (int i = 1; i < ondas.Length - 1; i++)
            {
                ondaAtual = ondas[i];
                ondaAnterior = ondas[i-1];
                ondaSeguinte = ondas[i+1];

                if (verificaPico(ondaAtual, ondaAnterior, ondaSeguinte))
                {
                    picos++;
                }
            }

            ondaAtual = ondas[ondas.Length-1];
            ondaAnterior = ondas[ondas.Length-2];
            ondaSeguinte = ondas[0];

            if (verificaPico(ondaAtual, ondaAnterior, ondaSeguinte))
            {
                picos++;
            }

            Console.WriteLine(picos);
        }
    }
}
