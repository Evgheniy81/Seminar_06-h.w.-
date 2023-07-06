
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine($"Введите размер массива: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Заполните массив целыми числами: ");
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Введен массив из {M} чисел: [{string.Join(", ", array)}]");

int GetCountPositivNumOfArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int count = GetCountPositivNumOfArray(array);
Console.WriteLine($"Количество положительных чисел массива: {count}");

////Заполнение случайными числами массива
/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}

int GetCountPositivNumOfArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] arr = CreateArray(10, -5, 25);

int count = GetCountPositivNumOfArray(arr);
Console.WriteLine($"Количество положительных чисел массива: {count}");
*/