// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReverseArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] array = CreateArray(12, -9, 9);
Print($"Our array is [{PrintArr(array)}]");
int[] reverseArray = (ReverseArray(array));
Print($"Our reverse array is [{reverseArray}]");
