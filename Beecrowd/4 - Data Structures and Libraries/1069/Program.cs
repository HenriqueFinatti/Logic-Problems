using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int casos = int.Parse(Console.ReadLine());

        while (casos > 0)
        {
            string diamantesNaAreia = Console.ReadLine();
            Stack<char> diamantesAbertos = new Stack<char>();
            int diamantes = 0;
            foreach (char item in diamantesNaAreia)
            {
                if (item == '<')
                {
                    diamantesAbertos.Push('<');
                    continue;
                }

                if (item == '>' && diamantesAbertos.Count > 0)
                {
                    diamantes++;
                    diamantesAbertos.Pop();
                    continue;
                }
            }
            Console.WriteLine(diamantes);

            casos--;
        }
    }
}
