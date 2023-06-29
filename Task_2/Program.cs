// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

string PrintArr(int[] array)
{
    return string.Join(", ", array);
}

void Print(string text)
{
    Console.WriteLine(text);
}

int GetNumber(string description)
{

    int number;
    Print($"{description} => ");

    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Print($"This number \"{temp}\" is not correct. Try again. => ");
    }
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

bool FindNumber(int[] array, int number)
{
    foreach (int item in array)
    {
        if (item == number)
        {
            return true;
        }
    }
    return false;
}

int number = GetNumber("Input number");
int[] array = CreateArray(12, 1, 9);
Print($"Our array is [{PrintArr(array)}]");
string answer = FindNumber(array, number) ? "Yes" : "No";
Print(answer);