//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if (m == 0)
        return AckermanFunction(n - 1, 1);
    else
        return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

Console.WriteLine("Input first number:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input second number:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Result: " + AckermanFunction(n, m));

