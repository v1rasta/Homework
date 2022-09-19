// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Input the first number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number:");
int n = Convert.ToInt32(Console.ReadLine());
int minValue = Math.Min(m, n);
int maxValue = Math.Max(m, n);
int sumValue = 0;

void RecIntervalSumNumber (int m, int n)
{
    int maxValue = Math.Max(m, n);
    if (minValue-1 != maxValue)
    {        
        RecIntervalSumNumber(minValue-1, maxValue-1);
        sumValue += maxValue;
    }
}

RecIntervalSumNumber (m, n);
Console.WriteLine(sumValue);