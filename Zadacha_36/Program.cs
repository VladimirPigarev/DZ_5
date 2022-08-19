// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int[] array = getArray(5, 1, 99);
WriteLine($"{String.Join(" ", array)}");
int sumOfElementsOfOddPositionsResult = sumOfElementsOfOddPositions(array);
WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sumOfElementsOfOddPositionsResult}");



int[] getArray(int size, int minValue, int maxValue)
{
    int[] rezult = new int[size];
    for(int index = 0; index < rezult.Length; index++)
    {
        rezult[index] = new Random().Next(minValue,maxValue+1);
    }
    return rezult;
}

int sumOfElementsOfOddPositions(int[] array2)
{
    int sumArrayPosition = 0;
    for(int i = 0; i < array2.Length; i++)
    {
        if(i % 2 == 1) sumArrayPosition = sumArrayPosition + array2[i];
    }
    return sumArrayPosition;
}
