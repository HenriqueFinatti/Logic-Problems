using System;
using System.Collections.Generic;
class Program
{
    static Stack<int> FormatInput()
    {
        Stack<int> formatedInput = new Stack<int>();

        string[] trainCars = Console.ReadLine().Split(' ');
        foreach(string item in trainCars)
        {
            if (item == "0")
            {
                return new Stack<int>();
            }
            formatedInput.Push(int.Parse(item));
        }

        return formatedInput;
    }

    static bool CanOrganize(Stack<int> arrivingTrain, int size)
    {
        Stack<int> station = new Stack<int>();
        while (true)
        {
            if (station.Count != 0 && station.Peek() == size)
            {
                station.Pop();
                size--;
                continue;
            }

            if (arrivingTrain.Count != 0 && arrivingTrain.Peek() == size)
            {
                arrivingTrain.Pop();
                size--;
                continue;
            }

            if (arrivingTrain.Count > 0)
            {
                station.Push(arrivingTrain.Pop());
                continue;
            }

            return size == 0 ? true : false;
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            int size = int.Parse(Console.ReadLine());

            if (size == 0) break;

            while (true)
            {
                Stack<int> arrivingTrain = FormatInput();
                if (arrivingTrain.Count == 0)
                {
                    Console.WriteLine();
                    break;
                }

                if (CanOrganize(arrivingTrain, size))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
