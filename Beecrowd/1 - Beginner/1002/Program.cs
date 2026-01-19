using System;

class Program
{
    static void Main(string[] args)
    {
        decimal n = 3.14159m;
        decimal r = Decimal.Parse(Console.ReadLine());
        decimal area = n * (r*r);

        Console.WriteLine($"A={area:F4}");
    }
}
