using System;

class Program
{
    static void Main(string[] args)
    {
        int casos = int.Parse(Console.ReadLine());

        while (casos > 0)
        {
            int[] entrada = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double n = entrada[0];
            double m = entrada[1];

            int sensoresColunas = (int)Math.Floor(n/3);
            int sensoresLinhas = (int)Math.Floor(m/3);

            Console.WriteLine(sensoresColunas * sensoresLinhas);
            casos--;
        }
    }
}
