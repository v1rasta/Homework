// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223 -> 4

Console.Clear();

int [] InputNumbers (int numbers)
{
    int [] array = new int [numbers];
    for(int i = 0; i < numbers; i++)
    {
        Console.WriteLine("Enter the number:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int CheckNumbers (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
System.Console.WriteLine("Enter the number of numbers");
int numbers = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckNumbers(InputNumbers(numbers)));