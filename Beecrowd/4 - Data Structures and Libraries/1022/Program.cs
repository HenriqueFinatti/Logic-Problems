using System;

class Program
{
    static void exibe(int Nfinal, int Dfinal)
    {
        Console.Write($"{Nfinal}/{Dfinal} = ");
        int value = mdc(Nfinal, Dfinal);
        Console.WriteLine($"{Nfinal/value}/{Dfinal/value}");
    }
    static int mdc(int num1, int num2) {

        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return Math.Abs(num1);
    }
    static void sum(int N1, int N2, int D1, int D2)
    {
        int Nfinal = N1*D2 + N2*D1;
        int Dfinal = D1*D2;

        exibe(Nfinal, Dfinal);
    }
    static void sub(int N1, int N2, int D1, int D2)
    {
        int Nfinal = N1*D2 - N2*D1;
        int Dfinal = D1*D2;

        exibe(Nfinal, Dfinal);
    }

    static void times(int N1, int N2, int D1, int D2)
    {
        int Nfinal = N1*N2;
        int Dfinal = D1*D2;

        exibe(Nfinal, Dfinal);
    }

    static void division(int N1, int N2, int D1, int D2)
    {
        int Nfinal = N1*D2;
        int Dfinal = N2*D1;

        exibe(Nfinal, Dfinal);
    }
    static void Main(string[] args)
    {
        int cases = int.Parse(Console.ReadLine());

        while (cases > 0)
        {
            string[] mathProblem = Console.ReadLine().Split(' ');
            int N1, N2, D1, D2;
            char operation = char.Parse(mathProblem[3]);

            N1 = int.Parse(mathProblem[0]);
            D1 = int.Parse(mathProblem[2]);

            N2 = int.Parse(mathProblem[4]);
            D2 = int.Parse(mathProblem[6]);

            switch (operation)
            {
                case '+':
                    sum(N1, N2, D1, D2);
                    break;
                case '-':
                    sub(N1, N2, D1, D2);
                    break;
                case '*':
                    times(N1, N2, D1, D2);
                    break;
                case '/':
                    division(N1, N2, D1, D2);
                    break;
            }
            cases--;
        }
    }
}
