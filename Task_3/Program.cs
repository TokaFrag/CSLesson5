// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

string PrintArr(int[] array)
{
    return string.Join(", ", array);
}

void Print(string text)
{
    Console.WriteLine(text);
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int FindNumber(int[] array, int min, int max)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item >= min && item <= max)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArray(123, 1, 999);
Print($"{PrintArr(array)}");
int count = FindNumber(array, 10, 99);
Print($"The number of numbers from 10 to 99 will be {count}");