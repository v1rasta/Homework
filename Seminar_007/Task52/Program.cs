// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ArithmeticMeanColumns (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
    Console.Write($"{sum / array.GetLength(0)} ");
    }
}

void Show2dArray (int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

int [,] myArray = CreateNewArray();
Show2dArray(myArray);
ArithmeticMeanColumns(myArray);