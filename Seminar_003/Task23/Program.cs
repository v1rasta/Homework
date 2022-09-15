// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
void CubeNumbers(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Таблица кубов числа {i} = {i*i*i}");
    }
}
Console.WriteLine("Input number:");
int result = Convert.ToInt32(Console.ReadLine());
CubeNumbers(result);