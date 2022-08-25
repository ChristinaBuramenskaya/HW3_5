// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1,150);
        Console.Write(collection[i] + " ");
        
    }
    Console.WriteLine();
}


void Result(int[] col)
{
    int count = col.Length;
    int x = 0;
    for (int j = 0; j < count; j++)
    {
        if (col[j] >=10 && col[j] <=99)
        {
            x++;
        }
    }
    Console.Write("Количество чисел от 10 до 99 = ");
    Console.Write(x);

}

int[] array = new int[123];
FillArray(array);
Result(array);