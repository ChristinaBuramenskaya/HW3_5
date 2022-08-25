// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 10);
        Console.Write(collection[i] + " ");

    }

}

void Result(int[] col)
{
    int result = 0;
    int count = col.Length;
    for (int j = 0; j < count; j++)
    {
        result = col[count - 1] - col[0];

    }
    Console.Write("Разница между максимальным и минимальным элементами массива = ");
    Console.WriteLine(result);
}


int[] array = new int[10];
FillArray(array);
Result(array);