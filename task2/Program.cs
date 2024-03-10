//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    if (n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine("Input first number:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input second number:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A({m},{n})= " + AckermanFunction(n, m));

