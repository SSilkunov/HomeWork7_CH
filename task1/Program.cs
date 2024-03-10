//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.




void PrintNaturalNambers(int min, int max)
{
    if(min == max - 1)
    { 
        return;
    }  
    Console.Write(min+1+ ", ");  
    PrintNaturalNambers(min+1, max);
}

Console.WriteLine("Input first number:");
int  M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input second number:");
int N = int.Parse(Console.ReadLine()!);
if(M == N)
Console.WriteLine("You input equal numbers");
if(M < N)
{
    Console.Write($"The natural numbers beetwin {M} and {N} are: ");
    PrintNaturalNambers(M,N);
}
if(M > N)
{
    Console.Write($"The natural numbers beetwin {M} and {N} are: ");
    PrintNaturalNambers(N,M);
}


