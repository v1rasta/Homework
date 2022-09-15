// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Clear();
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindNegativeSum (int [] array)
{
    
    int sum = 0;
    for(int i = 1; i <array.Length; i+=2)
    {
        sum+= array[i];
    }
    return sum;
}
Console.WriteLine("Indicate the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indicate the minimum value of the array index:");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indicate the maximum value of the array index:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(newArray);

Console.WriteLine($"The sum of the elements standing in odd position is equal {FindNegativeSum(newArray)}");



