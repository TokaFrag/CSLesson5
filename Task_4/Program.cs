// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] FindMultiplicationNumber(int[] array)
{
    int count = array.Length / 2;
    if (array.Length % 2 != 0)
    {
        count += 1;
    }
    int[] arrayMultiplication = new int[count];

    for (int i = 0, j = array.Length - 1; i <= j; i++, j--)
    {
        if (i == j)
        {
            arrayMultiplication[i] = array[i];
            return arrayMultiplication;
        }
        else
        {
            arrayMultiplication[i] = array[i] * array[j];
        }
    }
    return arrayMultiplication;
}

int[] array = CreateArray(9, 1, 9);
Print($"{PrintArr(array)}");
int[] arrayMultiplication = FindMultiplicationNumber(array);
Print($"{PrintArr(arrayMultiplication)}");