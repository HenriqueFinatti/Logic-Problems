using System;

class Program
{
    static void Main(string[] args)
    {
        string[] row1 = Console.ReadLine().Split(' ');
        string[] row2 = Console.ReadLine().Split(' ');

        int qtd1 = int.Parse(row1[1]);
        int qtd2 = int.Parse(row2[1]);

        double value1 = double.Parse(row1[2]) * qtd1;
        double value2 = double.Parse(row2[2]) * qtd2;

        Console.WriteLine($"VALOR A PAGAR: R$ {(value1 + value2):F2}");
    }
}
