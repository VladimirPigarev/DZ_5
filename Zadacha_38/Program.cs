// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


using static System.Console;
Clear();

int [] array = getArray(7, -10, 10);
WriteLine($"{String.Join(" ", array)}");
int max = differenceMaxNumbersArray(array);
int min = differenceMinNumbersArray(array);
int result = max - min;
WriteLine($"Разница между max и min элементами массива равна {result}");

int[] getArray(int size, int minValue, int maxValue)
{
    int[] rezult = new int[size];
    for(int i = 0; i < rezult.Length; i++)
    {
        rezult[i] = new Random().Next(minValue, maxValue);
    }
    return rezult;
}


int differenceMaxNumbersArray (int[] array1)
{
    int max = array1[0];
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i] > max) max = array1[i];
    }
    return max; 
}

int differenceMinNumbersArray (int[] array2)
{
    int min = array2[0];
    for(int i = 0; i < array2.Length; i++)
    {
        if(array2[i] < min) min = array2[i];
    }
    return min;
}