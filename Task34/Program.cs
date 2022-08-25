// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100, 999);
        Console.WriteLine(collection[i] + " ");

    }

}

void Result(int[] col)
{
    int count = 0;
    int j = 0;
    while (j < col.Length)
    {
        if (col[j] % 2 != 0)
        {
            j++;
        }
        else
        {
            count = count + 1;
            j++;
        }

    }
    
Console.Write("Четных чисел ");
Console.WriteLine(count);
}


int[] array = new int[10];
FillArray(array);
Result(array);