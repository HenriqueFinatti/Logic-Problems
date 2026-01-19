using System;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double salesBonus = double.Parse(Console.ReadLine()) * 0.15;
        double finalSalary = salary + salesBonus;

        Console.WriteLine($"TOTAL = R$ {finalSalary:F2}");

    }
}
