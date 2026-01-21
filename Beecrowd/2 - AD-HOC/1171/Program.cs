using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int cases = int.Parse(Console.ReadLine());
        SortedDictionary<int, int> numbersList = new SortedDictionary<int, int>();

        while (cases > 0)
        {
            int number = int.Parse(Console.ReadLine());
            if (numbersList.ContainsKey(number))
            {
                numbersList[number]++;
            }
            else
            {
                numbersList.Add(number, 1);
            }
            cases--;
        }

        foreach (int item in numbersList.Keys)
        {
            Console.WriteLine($"{item} aparece {numbersList[item]} vez(es)");
        }
    }
}
