// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
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
int FindNum (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i]%2 ==0)
            count++;
    }
    return count;
}

Console.WriteLine("Indicate the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indicate the minimum value of the array index:");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indicate the maximum value of the array index:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(newArray);

Console.WriteLine($"The number of even three-digit numbers in the array is equal {FindNum(newArray)}");