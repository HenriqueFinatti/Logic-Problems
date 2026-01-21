using System;
using System.Collections.Generic;
class Program
{
    static (int, int)[] movesetCavalo =
    {
        (-2, -1), (-2, 1), (2, -1), (2, 1),
        (-1, 2), (-1, -2), (1, 2), (1, -2)
    };

    static HashSet<(int, int)> calculaMovimentosPeao()
    {
        HashSet<(int, int)> posicoesInvalidas = new HashSet<(int, int)>();
        for (int k = 0; k < 8; k++)
        {
            string peao = Console.ReadLine();
            if (peao[0] != '1')
            {
                int novaLinha = '8' - peao[0] + 1;
                int casaEsquerda = peao[1] - 'a' - 1;
                int casaDireita = peao[1] - 'a'  + 1;

                posicoesInvalidas.Add((novaLinha, casaEsquerda));
                posicoesInvalidas.Add((novaLinha, casaDireita));
            }
        }
        return posicoesInvalidas;
    }
    static void Main(string[] args)
    {
        int casos = 1;

        while (true)
        {
            HashSet<(int, int)> posicoesInvalidas = new HashSet<(int, int)>();

            string cavalo = Console.ReadLine();
            if (cavalo == "0") break;

            posicoesInvalidas = calculaMovimentosPeao();

            int movimentosValidos = 0;
            foreach ((int, int) a in movesetCavalo)
            {
                int linha = '8' - cavalo[0] + a.Item1;
                int coluna = cavalo[1] - 'a' + a.Item2;

                if (linha < 8 && linha >= 0 && coluna < 8 && coluna >= 0)
                {
                    if (!posicoesInvalidas.Contains((linha, coluna)))
                    {
                        movimentosValidos++;
                    }
                }
            }

            Console.WriteLine($"Caso de Teste #{casos}: {movimentosValidos} movimento(s).");
            casos++;
        }
    }
}
