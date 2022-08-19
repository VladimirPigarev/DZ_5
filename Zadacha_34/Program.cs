// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int[] array = GetArray(6, 100, 999);
WriteLine($"{String.Join(" ", array)}");
int numberOfEvenResult = numberOfEven(array);
WriteLine($"Количество четных чисел в массиве = {numberOfEvenResult}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int numberOfEven(int[] array2)
{
    int count = 0;
    for (int index = 0; index < array2.Length; index++)
    {
        if((array2[index] % 2) == 0)
        {
            count++;
        }
    }
    return count;
}