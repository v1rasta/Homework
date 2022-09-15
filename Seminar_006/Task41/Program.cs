// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();


int CreatedArray (int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Enter the number {i + 1}:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
            count++;
    }
    return count;
}
Console.WriteLine("Enter the number of numbers:");
int numbers =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Positive numbers: {CreatedArray(numbers)}");