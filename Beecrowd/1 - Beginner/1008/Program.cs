using System;

class Program
{
    static void Main(string[] args)
    {
        int employeeId = int.Parse(Console.ReadLine());
        int hoursWorked = int.Parse(Console.ReadLine());

        double hourValue = double.Parse(Console.ReadLine());
        double salary = hoursWorked * hourValue;
        Console.WriteLine("NUMBER = " + employeeId);
        Console.WriteLine($"SALARY = U$ {salary:F2}");
    }
}
