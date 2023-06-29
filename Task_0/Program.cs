// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

(int sumNeg, int sumPos) FindNegPos(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    foreach (int item in array)
    {
        sumPos += item > 0 ? item : 0;
        sumNeg += item < 0 ? item : 0;
    }
    return (sumNeg: sumNeg, sumPos: sumPos);

}

int[] array = CreateArray(12, -9, 9);
Print($"Our array is [{PrintArr(array)}]");

var tuple = FindNegPos(array);
int sumNeg = tuple.sumNeg;
int sumPos = tuple.sumPos;
Print($"Sum negative is {sumNeg} and sum positive is {sumPos}.");