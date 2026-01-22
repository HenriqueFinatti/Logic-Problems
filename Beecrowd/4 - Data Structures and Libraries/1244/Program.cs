using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int casos = int.Parse(Console.ReadLine());

        while (casos > 0)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            SortedDictionary<int, List<string>> palavrasOrdenadas = new SortedDictionary<int, List<string>>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            for (int i = 0; i < entrada.Length; i++)
            {
                List<string> temp = new List<string>();
                temp.Add(entrada[i]);

                if (palavrasOrdenadas.ContainsKey(entrada[i].Length))
                {
                    palavrasOrdenadas[entrada[i].Length].Add(entrada[i]);
                    continue;
                }
                palavrasOrdenadas.Add(entrada[i].Length, temp);
            }

            int aux = 0;
            foreach (List<string> palavras in palavrasOrdenadas.Values)
            {
                foreach (string palavra in palavras)
                {
                    if (aux > 0)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(palavra);
                    aux++;
                }
            }
            Console.WriteLine();
            casos--;
        }
    }
}
