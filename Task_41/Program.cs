
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max);
    }
    Console.WriteLine($"Our array [{string.Join(", ", array)}]");
    return array;
}
*/
/*
Console.WriteLine($"Заполните массив целыми числами");
int[] CreateArray(int size, int min, int max);
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Our array [{string.Join(", ", array)}]");

Console.Write("Заполните массив целыми числами => ");
//int N1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("[{0}]", string.Join("\n", array));
//array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
*/
/*
int GetCountPositivNumOfArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0)
        {
            count++;
        }
        return count;
    }
}
int[] arr = CreateArray(20, -5, 10);

int count = GetCountPositivNumOfArray(array);
Console.WriteLine($"Count of positiv numbers: {count}");
*/
/*
void CreateArray()
{
    Console.WriteLine($"Заполните массив целыми числами");
    int[] array = { };
    Console.Write($"Our array [{string.Join(", ", array)}]");
    
}
*/
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
int[] arr = CreateArray(10, -5, 5);

int count = GetCountPositivNumOfArray(arr);
Console.WriteLine($"Количество положительных чисел массива = {count}");



