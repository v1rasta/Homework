// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();

Console.WriteLine("Input the first number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number:");
int n = Convert.ToInt32(Console.ReadLine());
int minValue = Math.Min(m, n);

void RecIntervalSeriesNumber (int m, int n)
{
    int maxValue = Math.Max(m, n);
    if(minValue-1 != maxValue)
    {
        RecIntervalSeriesNumber(maxValue-1, minValue-1);
        Console.Write($"{maxValue} ");
    }
}


RecIntervalSeriesNumber (m, n);

