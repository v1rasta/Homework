// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray ()
{
Console.WriteLine("Введите количество элементов массива:");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int [] myArray = new int[elementsCount];
for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}:");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
    
}

return myArray;
}
void PrintArray(int [] myArray)
{
    Console.Write("[");
    for (int i = 0; i <myArray.Length; i ++)
        Console.Write($"{myArray[i]}, ");
    Console.Write("\b\b]");
}


PrintArray(CreateArray());