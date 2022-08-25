// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1,10);
        Console.Write(collection[i] + " ");

    }

}

void Result(int[] col)
{
    int count = col.Length;
    int sum = 0;
    for (int j = 0; j < count; j++)
    {
        if (j % 2 != 0)
        {
            sum += col[j]; 
        }
    }
    Console.Write("Сумма элементов массива, находящихся на нечетных позициях = ");
    Console.WriteLine(sum);
}

int[] array = new int [10];
FillArray(array);
Result(array);