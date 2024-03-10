//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ReversPrintArray(int[] array, int index)
{
    if (index < 0)
        return;
    Console.Write($"{array[index]}, ");
    ReversPrintArray(array, index - 1);
}

int[] array = new int[10];
Console.WriteLine("Basic array");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write($"{array[i]}, ");
}
int index = array.Length-1;
Console.WriteLine("\nRezult array");
ReversPrintArray(array, index);