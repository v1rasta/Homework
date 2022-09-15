// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double [] CreateRandomArray (int size, int minValue, int maxValue)
{
    double [] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        double PartOne = new Random().Next(minValue, maxValue + 1);
        double PartTwo = new Random().NextDouble();
        newArray [i] = PartOne + PartTwo;
    }
    return newArray;
}
void ShowArray(double [] array)
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double FindDifference (double [] array)
{
    double min = array [0];
    double max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min) min = array [i];
        if (array [i] > max) max = array [i];
    }
    double differ = max - min;
    return differ;
}
Console.WriteLine("Indicate the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Indicate the minimum value of the array index:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Indicate the maximum value of the array index:");
int maxValue = Convert.ToInt32(Console.ReadLine());

double [] newArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(newArray);

double difference = FindDifference(newArray);
Console.WriteLine("Разница между максимальным и минимальным значением равна"+ difference);

