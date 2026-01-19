using System;
class Program
{
    static void Main(string[] args)
    {

        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());

        double avg = (number1 * 3.5 + number2 * 7.5) / 11;

        Console.WriteLine($"MEDIA = {avg:F5}");
    }
}
