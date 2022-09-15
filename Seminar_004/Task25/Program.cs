// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
int FindNumber (int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine("Input A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumber(a, b));