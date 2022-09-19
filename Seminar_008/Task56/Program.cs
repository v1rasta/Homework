// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int [,] CreateNewArray ()
{
    Console.Write("Input the number of rows:");
    int rows = int.Parse(Console.ReadLine());
    
    Console.Write("Input the number of columns:");
    int columns = int.Parse(Console.ReadLine());
    
    Console.Write("Input min possible value:");
    int minValue = int.Parse(Console.ReadLine());
    
    Console.Write("Input max possible value:");
    int maxValue = int.Parse(Console.ReadLine());
    
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void MinimalSumIndexRow (int [,] array)
{
    int minsum = 0;
    int minindexrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
           
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            minindexrow = i;
        }
        Console.WriteLine($"Cумма элементов строки {i+1} равна {sum}");
    }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[minindexrow, j] + " ";
    }
    Console.WriteLine($"Строка [{line}]с минимальной суммой элементов {minindexrow}. ");
}

void Show2dArray (int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

int [,] myArray = CreateNewArray();
Show2dArray(myArray);
MinimalSumIndexRow(myArray);
